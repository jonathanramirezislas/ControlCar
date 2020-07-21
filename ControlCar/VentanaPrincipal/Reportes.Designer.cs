namespace VentanaPrincipal
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAutoACTIVOS = new System.Windows.Forms.Button();
            this.buttonAutoDesac = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAltorend = new System.Windows.Forms.Button();
            this.buttonbajorend = new System.Windows.Forms.Button();
            this.textBoxRend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAutomoviles = new System.Windows.Forms.Button();
            this.dateTimePickerFecInic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecFina = new System.Windows.Forms.DateTimePicker();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPlacas = new System.Windows.Forms.TextBox();
            this.buttonCARGAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(858, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAutoACTIVOS
            // 
            this.buttonAutoACTIVOS.Location = new System.Drawing.Point(12, 42);
            this.buttonAutoACTIVOS.Name = "buttonAutoACTIVOS";
            this.buttonAutoACTIVOS.Size = new System.Drawing.Size(94, 51);
            this.buttonAutoACTIVOS.TabIndex = 1;
            this.buttonAutoACTIVOS.Text = "Automoviles Activos";
            this.buttonAutoACTIVOS.UseVisualStyleBackColor = true;
            this.buttonAutoACTIVOS.Click += new System.EventHandler(this.buttonAutoACTIVOS_Click);
            // 
            // buttonAutoDesac
            // 
            this.buttonAutoDesac.Location = new System.Drawing.Point(122, 42);
            this.buttonAutoDesac.Name = "buttonAutoDesac";
            this.buttonAutoDesac.Size = new System.Drawing.Size(95, 51);
            this.buttonAutoDesac.TabIndex = 2;
            this.buttonAutoDesac.Text = "Automoviles NO Activos";
            this.buttonAutoDesac.UseVisualStyleBackColor = true;
            this.buttonAutoDesac.Click += new System.EventHandler(this.buttonAutoDesac_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fec Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fec Fin";
            // 
            // buttonAltorend
            // 
            this.buttonAltorend.Location = new System.Drawing.Point(457, 115);
            this.buttonAltorend.Name = "buttonAltorend";
            this.buttonAltorend.Size = new System.Drawing.Size(99, 47);
            this.buttonAltorend.TabIndex = 7;
            this.buttonAltorend.Text = "Alto Rendimiento";
            this.buttonAltorend.UseVisualStyleBackColor = true;
            this.buttonAltorend.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonbajorend
            // 
            this.buttonbajorend.Location = new System.Drawing.Point(653, 117);
            this.buttonbajorend.Name = "buttonbajorend";
            this.buttonbajorend.Size = new System.Drawing.Size(96, 45);
            this.buttonbajorend.TabIndex = 8;
            this.buttonbajorend.Text = "Bajo Rendimiento";
            this.buttonbajorend.UseVisualStyleBackColor = true;
            this.buttonbajorend.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxRend
            // 
            this.textBoxRend.Location = new System.Drawing.Point(554, 71);
            this.textBoxRend.Name = "textBoxRend";
            this.textBoxRend.Size = new System.Drawing.Size(100, 22);
            this.textBoxRend.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rendiemiento de";
            // 
            // buttonAutomoviles
            // 
            this.buttonAutomoviles.Location = new System.Drawing.Point(225, 130);
            this.buttonAutomoviles.Name = "buttonAutomoviles";
            this.buttonAutomoviles.Size = new System.Drawing.Size(179, 44);
            this.buttonAutomoviles.TabIndex = 11;
            this.buttonAutomoviles.Text = "CARGAS DEL CARRO";
            this.buttonAutomoviles.UseVisualStyleBackColor = true;
            this.buttonAutomoviles.Click += new System.EventHandler(this.buttonAutomoviles_Click);
            // 
            // dateTimePickerFecInic
            // 
            this.dateTimePickerFecInic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecInic.Location = new System.Drawing.Point(423, 25);
            this.dateTimePickerFecInic.Name = "dateTimePickerFecInic";
            this.dateTimePickerFecInic.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerFecInic.TabIndex = 21;
            this.dateTimePickerFecInic.Value = new System.DateTime(2017, 11, 15, 1, 0, 0, 0);
            // 
            // dateTimePickerFecFina
            // 
            this.dateTimePickerFecFina.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecFina.Location = new System.Drawing.Point(664, 25);
            this.dateTimePickerFecFina.Name = "dateTimePickerFecFina";
            this.dateTimePickerFecFina.Size = new System.Drawing.Size(126, 22);
            this.dateTimePickerFecFina.TabIndex = 22;
            this.dateTimePickerFecFina.Value = new System.DateTime(2017, 11, 15, 1, 0, 0, 0);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(563, 169);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 24;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Placas";
            // 
            // textBoxPlacas
            // 
            this.textBoxPlacas.Location = new System.Drawing.Point(117, 144);
            this.textBoxPlacas.Name = "textBoxPlacas";
            this.textBoxPlacas.Size = new System.Drawing.Size(100, 22);
            this.textBoxPlacas.TabIndex = 27;
            // 
            // buttonCARGAS
            // 
            this.buttonCARGAS.Location = new System.Drawing.Point(238, 76);
            this.buttonCARGAS.Name = "buttonCARGAS";
            this.buttonCARGAS.Size = new System.Drawing.Size(157, 39);
            this.buttonCARGAS.TabIndex = 28;
            this.buttonCARGAS.Text = "TODAS LAS CARGAS";
            this.buttonCARGAS.UseVisualStyleBackColor = true;
            this.buttonCARGAS.Click += new System.EventHandler(this.buttonCARGAS_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 402);
            this.Controls.Add(this.buttonCARGAS);
            this.Controls.Add(this.textBoxPlacas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dateTimePickerFecFina);
            this.Controls.Add(this.dateTimePickerFecInic);
            this.Controls.Add(this.buttonAutomoviles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRend);
            this.Controls.Add(this.buttonbajorend);
            this.Controls.Add(this.buttonAltorend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAutoDesac);
            this.Controls.Add(this.buttonAutoACTIVOS);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAutoACTIVOS;
        private System.Windows.Forms.Button buttonAutoDesac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAltorend;
        private System.Windows.Forms.Button buttonbajorend;
        private System.Windows.Forms.TextBox textBoxRend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAutomoviles;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecInic;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecFina;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPlacas;
        private System.Windows.Forms.Button buttonCARGAS;
    }
}