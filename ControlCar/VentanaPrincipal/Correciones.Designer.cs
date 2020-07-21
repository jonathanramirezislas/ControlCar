namespace VentanaPrincipal
{
    partial class Correciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Correciones));
            this.buttoncorreg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDireccion = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonsaalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePickerFechaAcoregir = new System.Windows.Forms.DateTimePicker();
            this.labelfecacorr = new System.Windows.Forms.Label();
            this.labelplaca = new System.Windows.Forms.Label();
            this.textBoxPlacas = new System.Windows.Forms.TextBox();
            this.buttonavanz = new System.Windows.Forms.Button();
            this.buttonatrazar = new System.Windows.Forms.Button();
            this.textBoxKm = new System.Windows.Forms.TextBox();
            this.labelkm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncorreg
            // 
            this.buttoncorreg.Location = new System.Drawing.Point(677, 89);
            this.buttoncorreg.Name = "buttoncorreg";
            this.buttoncorreg.Size = new System.Drawing.Size(97, 31);
            this.buttoncorreg.TabIndex = 0;
            this.buttoncorreg.Text = "Corregir";
            this.buttoncorreg.UseVisualStyleBackColor = true;
            this.buttoncorreg.Visible = false;
            this.buttoncorreg.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 88);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonDireccion
            // 
            this.buttonDireccion.Location = new System.Drawing.Point(831, 269);
            this.buttonDireccion.Name = "buttonDireccion";
            this.buttonDireccion.Size = new System.Drawing.Size(75, 23);
            this.buttonDireccion.TabIndex = 30;
            this.buttonDireccion.Text = "Direccion";
            this.buttonDireccion.UseVisualStyleBackColor = true;
            this.buttonDireccion.Click += new System.EventHandler(this.buttonDireccion_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 54);
            this.button5.TabIndex = 31;
            this.button5.Text = "Guardar el archivo ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(780, 236);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 22);
            this.textBoxName.TabIndex = 32;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(1159, 160);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 33;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonsaalir
            // 
            this.buttonsaalir.Location = new System.Drawing.Point(903, 318);
            this.buttonsaalir.Name = "buttonsaalir";
            this.buttonsaalir.Size = new System.Drawing.Size(75, 23);
            this.buttonsaalir.TabIndex = 34;
            this.buttonsaalir.Text = "Salir";
            this.buttonsaalir.UseVisualStyleBackColor = true;
            this.buttonsaalir.Click += new System.EventHandler(this.buttonsaalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Informacion Actual de los carros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre del archivo";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 56);
            this.button4.TabIndex = 38;
            this.button4.Text = "Iniciar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // dateTimePickerFechaAcoregir
            // 
            this.dateTimePickerFechaAcoregir.Location = new System.Drawing.Point(316, 91);
            this.dateTimePickerFechaAcoregir.Name = "dateTimePickerFechaAcoregir";
            this.dateTimePickerFechaAcoregir.ShowUpDown = true;
            this.dateTimePickerFechaAcoregir.Size = new System.Drawing.Size(315, 22);
            this.dateTimePickerFechaAcoregir.TabIndex = 27;
            this.dateTimePickerFechaAcoregir.Value = new System.DateTime(2017, 11, 15, 7, 0, 0, 0);
            this.dateTimePickerFechaAcoregir.Visible = false;
            this.dateTimePickerFechaAcoregir.ValueChanged += new System.EventHandler(this.dateTimePickerFechaAcoregir_ValueChanged);
            // 
            // labelfecacorr
            // 
            this.labelfecacorr.AutoSize = true;
            this.labelfecacorr.Location = new System.Drawing.Point(433, 55);
            this.labelfecacorr.Name = "labelfecacorr";
            this.labelfecacorr.Size = new System.Drawing.Size(112, 17);
            this.labelfecacorr.TabIndex = 29;
            this.labelfecacorr.Text = "Fecha a corregir";
            this.labelfecacorr.Visible = false;
            this.labelfecacorr.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelplaca
            // 
            this.labelplaca.AutoSize = true;
            this.labelplaca.Location = new System.Drawing.Point(234, 17);
            this.labelplaca.Name = "labelplaca";
            this.labelplaca.Size = new System.Drawing.Size(43, 17);
            this.labelplaca.TabIndex = 5;
            this.labelplaca.Text = "Placa";
            this.labelplaca.Visible = false;
            this.labelplaca.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPlacas
            // 
            this.textBoxPlacas.Location = new System.Drawing.Point(298, 12);
            this.textBoxPlacas.Name = "textBoxPlacas";
            this.textBoxPlacas.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlacas.TabIndex = 6;
            this.textBoxPlacas.Visible = false;
            // 
            // buttonavanz
            // 
            this.buttonavanz.Location = new System.Drawing.Point(360, 144);
            this.buttonavanz.Name = "buttonavanz";
            this.buttonavanz.Size = new System.Drawing.Size(75, 23);
            this.buttonavanz.TabIndex = 1;
            this.buttonavanz.Text = ">";
            this.buttonavanz.UseVisualStyleBackColor = true;
            this.buttonavanz.Visible = false;
            this.buttonavanz.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonatrazar
            // 
            this.buttonatrazar.Location = new System.Drawing.Point(191, 144);
            this.buttonatrazar.Name = "buttonatrazar";
            this.buttonatrazar.Size = new System.Drawing.Size(75, 23);
            this.buttonatrazar.TabIndex = 2;
            this.buttonatrazar.Text = "<";
            this.buttonatrazar.UseVisualStyleBackColor = true;
            this.buttonatrazar.Visible = false;
            this.buttonatrazar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxKm
            // 
            this.textBoxKm.Location = new System.Drawing.Point(156, 93);
            this.textBoxKm.Name = "textBoxKm";
            this.textBoxKm.Size = new System.Drawing.Size(100, 22);
            this.textBoxKm.TabIndex = 7;
            this.textBoxKm.Visible = false;
            this.textBoxKm.TextChanged += new System.EventHandler(this.textBoxKm_TextChanged);
            // 
            // labelkm
            // 
            this.labelkm.AutoSize = true;
            this.labelkm.Location = new System.Drawing.Point(153, 55);
            this.labelkm.Name = "labelkm";
            this.labelkm.Size = new System.Drawing.Size(102, 17);
            this.labelkm.TabIndex = 28;
            this.labelkm.Text = "Km A coorregir";
            this.labelkm.Visible = false;
            this.labelkm.Click += new System.EventHandler(this.label2_Click);
            // 
            // Correciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 373);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonsaalir);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonDireccion);
            this.Controls.Add(this.labelfecacorr);
            this.Controls.Add(this.labelkm);
            this.Controls.Add(this.dateTimePickerFechaAcoregir);
            this.Controls.Add(this.textBoxKm);
            this.Controls.Add(this.textBoxPlacas);
            this.Controls.Add(this.labelplaca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonatrazar);
            this.Controls.Add(this.buttonavanz);
            this.Controls.Add(this.buttoncorreg);
            this.Name = "Correciones";
            this.Text = "Correciones";
            this.Load += new System.EventHandler(this.Correciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncorreg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDireccion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonsaalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaAcoregir;
        private System.Windows.Forms.Label labelfecacorr;
        private System.Windows.Forms.Label labelplaca;
        private System.Windows.Forms.TextBox textBoxPlacas;
        private System.Windows.Forms.Button buttonavanz;
        private System.Windows.Forms.Button buttonatrazar;
        private System.Windows.Forms.TextBox textBoxKm;
        private System.Windows.Forms.Label labelkm;
    }
}