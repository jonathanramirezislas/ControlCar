namespace VentanaPrincipal
{
    partial class Cargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargas));
            this.buttonCarga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSeleccion = new System.Windows.Forms.Button();
            this.buttonCorregir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCARGAS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCarga
            // 
            this.buttonCarga.Location = new System.Drawing.Point(226, 100);
            this.buttonCarga.Name = "buttonCarga";
            this.buttonCarga.Size = new System.Drawing.Size(125, 51);
            this.buttonCarga.TabIndex = 0;
            this.buttonCarga.Text = "Cargar";
            this.buttonCarga.UseVisualStyleBackColor = true;
            this.buttonCarga.Click += new System.EventHandler(this.buttonCarga_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 22);
            this.textBox1.TabIndex = 1;
            // 
            // buttonSeleccion
            // 
            this.buttonSeleccion.Location = new System.Drawing.Point(436, 72);
            this.buttonSeleccion.Name = "buttonSeleccion";
            this.buttonSeleccion.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccion.TabIndex = 2;
            this.buttonSeleccion.Text = "Direccion";
            this.buttonSeleccion.UseVisualStyleBackColor = true;
            this.buttonSeleccion.Click += new System.EventHandler(this.buttonSeleccion_Click);
            // 
            // buttonCorregir
            // 
            this.buttonCorregir.Location = new System.Drawing.Point(554, 184);
            this.buttonCorregir.Name = "buttonCorregir";
            this.buttonCorregir.Size = new System.Drawing.Size(90, 54);
            this.buttonCorregir.TabIndex = 3;
            this.buttonCorregir.Text = "Corregir";
            this.buttonCorregir.UseVisualStyleBackColor = true;
            this.buttonCorregir.Visible = false;
            this.buttonCorregir.Click += new System.EventHandler(this.buttonCorregir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(673, 251);
            this.dataGridView1.TabIndex = 6;
            // 
            // buttonCARGAS
            // 
            this.buttonCARGAS.Location = new System.Drawing.Point(55, 215);
            this.buttonCARGAS.Name = "buttonCARGAS";
            this.buttonCARGAS.Size = new System.Drawing.Size(166, 23);
            this.buttonCARGAS.TabIndex = 5;
            this.buttonCARGAS.Text = "TODAS LAS CARGAS";
            this.buttonCARGAS.UseVisualStyleBackColor = true;
            this.buttonCARGAS.Click += new System.EventHandler(this.buttonCARGAS_Click);
            // 
            // Cargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(676, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCARGAS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCorregir);
            this.Controls.Add(this.buttonSeleccion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCarga);
            this.Name = "Cargas";
            this.Text = "Cargas";
            this.Load += new System.EventHandler(this.Cargas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCarga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSeleccion;
        private System.Windows.Forms.Button buttonCorregir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCARGAS;
    }
}