namespace VentanaPrincipal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificaciones = new System.Windows.Forms.Button();
            this.buttonCargas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReportes.BackgroundImage")));
            this.buttonReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonReportes.Location = new System.Drawing.Point(464, 180);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(194, 40);
            this.buttonReportes.TabIndex = 1;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.BackgroundImage")));
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonAgregar.Location = new System.Drawing.Point(462, 12);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(196, 41);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEliminar.Location = new System.Drawing.Point(464, 246);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(194, 41);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificaciones
            // 
            this.buttonModificaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonModificaciones.BackgroundImage")));
            this.buttonModificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonModificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificaciones.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonModificaciones.Location = new System.Drawing.Point(462, 123);
            this.buttonModificaciones.Name = "buttonModificaciones";
            this.buttonModificaciones.Size = new System.Drawing.Size(194, 41);
            this.buttonModificaciones.TabIndex = 4;
            this.buttonModificaciones.Text = "Modificaciones";
            this.buttonModificaciones.UseVisualStyleBackColor = true;
            this.buttonModificaciones.Click += new System.EventHandler(this.buttonModificaciones_Click);
            // 
            // buttonCargas
            // 
            this.buttonCargas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCargas.BackgroundImage")));
            this.buttonCargas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCargas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCargas.Location = new System.Drawing.Point(462, 66);
            this.buttonCargas.Name = "buttonCargas";
            this.buttonCargas.Size = new System.Drawing.Size(196, 39);
            this.buttonCargas.TabIndex = 5;
            this.buttonCargas.Text = "Cargas";
            this.buttonCargas.UseVisualStyleBackColor = true;
            this.buttonCargas.Click += new System.EventHandler(this.buttonCargas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 318);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCargas);
            this.Controls.Add(this.buttonModificaciones);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonReportes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EMPRESA VEHICULOS JONAS";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificaciones;
        private System.Windows.Forms.Button buttonCargas;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

