namespace importarDatos.Views
{
    partial class Formulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            label1 = new Label();
            btnImportar = new Button();
            btnExportar = new Button();
            dataGridView1 = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            label2 = new Label();
            btnGuardar = new Button();
            panel1 = new Panel();
            lblCantidadTotalDeDatos = new Label();
            label3 = new Label();
            nudCantidadDatos = new NumericUpDown();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 20);
            label1.Name = "label1";
            label1.Size = new Size(228, 29);
            label1.TabIndex = 0;
            label1.Text = "IMPORTAR TABLA";
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.FromArgb(0, 192, 192);
            btnImportar.Cursor = Cursors.Hand;
            btnImportar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            btnImportar.ForeColor = SystemColors.ButtonHighlight;
            btnImportar.Location = new Point(128, 104);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(145, 35);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar Datos";
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Red;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold);
            btnExportar.ForeColor = SystemColors.ButtonHighlight;
            btnExportar.Location = new Point(29, 251);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(145, 35);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar Datos";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Size = new Size(741, 346);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(346, 23);
            label2.TabIndex = 4;
            label2.Text = "Clic Para Selecionar Archivo";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LimeGreen;
            btnGuardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(25, 508);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(173, 30);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar Datos";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblCantidadTotalDeDatos);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nudCantidadDatos);
            panel1.Controls.Add(btnExportar);
            panel1.Location = new Point(803, 145);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 318);
            panel1.TabIndex = 6;
            // 
            // lblCantidadTotalDeDatos
            // 
            lblCantidadTotalDeDatos.AutoSize = true;
            lblCantidadTotalDeDatos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidadTotalDeDatos.Location = new Point(8, 93);
            lblCantidadTotalDeDatos.Name = "lblCantidadTotalDeDatos";
            lblCantidadTotalDeDatos.Size = new Size(39, 15);
            lblCantidadTotalDeDatos.TabIndex = 8;
            lblCantidadTotalDeDatos.Text = "Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Turquoise;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 11);
            label3.Name = "label3";
            label3.Size = new Size(186, 38);
            label3.TabIndex = 7;
            label3.Text = "Selecione la Cantidad de\nDatos a Exportar";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // nudCantidadDatos
            // 
            nudCantidadDatos.BackColor = SystemColors.Window;
            nudCantidadDatos.BorderStyle = BorderStyle.FixedSingle;
            nudCantidadDatos.Cursor = Cursors.IBeam;
            nudCantidadDatos.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidadDatos.Location = new Point(29, 176);
            nudCantidadDatos.Name = "nudCantidadDatos";
            nudCantidadDatos.Size = new Size(145, 26);
            nudCantidadDatos.TabIndex = 3;
            // 
            // Formulario
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1030, 550);
            Controls.Add(btnGuardar);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnImportar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Formulario";
            Text = "Formulario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Button btnImportar;
        public Button btnExportar;
        private DataGridView dataGridView1;
        public OpenFileDialog openFileDialog1;
        private Label label2;
        private Button btnGuardar;
        private Panel panel1;
        private SaveFileDialog saveFileDialog1;
        private Label label3;
        private NumericUpDown nudCantidadDatos;
        private Label lblCantidadTotalDeDatos;
    }
}