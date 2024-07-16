using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using importarDatos.Ent;
using ImportarDatos.Bll;
using MetroFramework;
using MetroFramework.Forms;

namespace importarDatos.Views
{
    public partial class Formulario : Form
    {
        private readonly Bll _controlador;
        public Formulario()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _controlador = new Bll(this);
            nudCantidadDatos.Maximum = 100000;
            Formulario_Load();
        }

        public void MostrarDatos(List<Datos> datos)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Código Loc", typeof(string));
            tabla.Columns.Add("Consec Ctr", typeof(string));
            tabla.Columns.Add("Código Trs", typeof(string));
            tabla.Columns.Add("ID Emp", typeof(string));
            tabla.Columns.Add("Valor Ctr", typeof(string));
            tabla.Columns.Add("Fecha Ctr", typeof(string));
            tabla.Columns.Add("Estado Ctr", typeof(string));

            foreach (var dato in datos)
            {
                tabla.Rows.Add(
                    dato.codigo_loc,
                    dato.consec_ctr,
                    dato.codigo_trs,
                    dato.id_emp,
                    dato.valor_ctr,
                    dato.fecha_ctr,
                    dato.estado_ctr
                );
            }

            dataGridView1.DataSource = tabla;
        }

        string archivoCsv;
        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivoCsv = openFileDialog.FileName;
                List<Datos> datos = _controlador.leerDatosDelArchivo(archivoCsv);
                MostrarDatos(datos);
            }
            else
            {
                MessageBox.Show("Error al leer el archivo CSV: \n" +
                    "\n !No has selecionado un archivo CSV¡");
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Datos> datos = ((DataTable)dataGridView1.DataSource).AsEnumerable()
                    .Select(row => new Datos
                    {
                        codigo_loc = int.Parse(row["Código Loc"].ToString()),
                        consec_ctr = int.Parse(row["Consec Ctr"].ToString()),
                        codigo_trs = int.Parse(row["Código Trs"].ToString()),
                        id_emp = float.Parse(row["ID Emp"].ToString()),
                        valor_ctr = int.Parse(row["Valor Ctr"].ToString()),
                        fecha_ctr = DateTime.Parse(row["Fecha Ctr"].ToString()),
                        estado_ctr = row["Estado Ctr"].ToString()
                    }).ToList();

                _controlador.guardarDatos(datos);
                MessageBox.Show("Datos guardados exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formulario_Load()
        {
            int cantidadTotalDeDatos = _controlador.ObtenerCantidadTotalDeDatos();
            lblCantidadTotalDeDatos.Text = $"Cantidad total de datos: {cantidadTotalDeDatos}";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            int cantidadDatos = (int)nudCantidadDatos.Value;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FileName = "Conversion de Datos.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                _controlador.ExportarArchivoCSV(rutaArchivo, cantidadDatos);
                MessageBox.Show("Archivo CSV generado exitosamente.");
            }
        }
    }
}
