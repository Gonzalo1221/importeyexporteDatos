using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using importarDatos.Ent;
using importarDatos.Views;
using CsvHelper;
using System.Text;

namespace ImportarDatos.Bll
{
    public class Bll
    {
        private readonly ApplicationDbContext _context;
        private readonly Formulario _formulario;

        public Bll(Formulario formulario)
        {
            _context = new ApplicationDbContext();
            _formulario = formulario;
        }
        public List<Datos> leerDatosDelArchivo(string archivoCsv)
        {
            var datos = new List<Datos>();
            using (var streamReader = new StreamReader(archivoCsv))
            {
                streamReader.ReadLine();
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] fila = line.Split(new char[] { ';' });
                    try
                    {
                        datos.Add(new Datos
                        {
                            codigo_loc = int.Parse(fila[0]),
                            consec_ctr = int.Parse(fila[1]),
                            codigo_trs = int.Parse(fila[2]),
                            id_emp = float.Parse(fila[3]),
                            valor_ctr = int.Parse(fila[4]),
                            fecha_ctr = DateTime.Parse(fila[5]),
                            estado_ctr = fila[6]
                        });
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine($"Error al leer fila: {line}");
                    }
                }
                return datos;

            }
        }
        public void guardarDatos(List<Datos> datos)
        {
            _context.Datos.AddRange(datos);
            _context.SaveChanges();
        }
        public int ObtenerCantidadTotalDeDatos()
        {
                return _context.Datos.Count();
        }
        public void ExportarArchivoCSV(string rutaArchivo, int cantidadDatos)
        {
            using (var context = new ApplicationDbContext())
            {
                var datos = context.Datos.OrderBy(d => d.codigo_loc).ThenBy(d => d.consec_ctr).Take(cantidadDatos).ToList();

                using (var writer = new StreamWriter(rutaArchivo, false, Encoding.UTF8))
                using (var csv = new CsvWriter(writer, CultureInfo.CurrentCulture))
                {
                    csv.WriteField("Código Loc");
                    csv.WriteField("Consec Ctr");
                    csv.WriteField("Código Trs");
                    csv.WriteField("ID Emp");
                    csv.WriteField("Valor Ctr");
                    csv.WriteField("Fecha Ctr");
                    csv.WriteField("Estado Ctr");
                    csv.NextRecord();

                    foreach (var dato in datos)
                    {
                        csv.WriteField(dato.codigo_loc);
                        csv.WriteField(dato.consec_ctr);
                        csv.WriteField(dato.codigo_trs);
                        csv.WriteField(dato.id_emp);
                        csv.WriteField(dato.valor_ctr);
                        csv.WriteField(dato.fecha_ctr.ToString("yyyy-MM-dd"));
                        csv.WriteField(dato.estado_ctr);
                        csv.NextRecord();
                    }
                }
            }
        }
    }
}
