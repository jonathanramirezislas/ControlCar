using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaPrincipal
{
    public partial class Form1 : Form
    {
        Agregar LLamarAgregar = new Agregar();
        Eliminar LlamarEliminar = new Eliminar();
        Modificaciones LLamarModificaciones = new Modificaciones();
        Reportes LlamarReportes = new Reportes();
        Cargas LlamarCargas = new Cargas();
      
        Correciones LlamarCorreciones = new Correciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LLamarAgregar.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            LlamarReportes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonModificaciones_Click(object sender, EventArgs e)
        {
            LLamarModificaciones.Show();
            
        }

        private void buttonCargas_Click(object sender, EventArgs e)
        {
            LlamarCargas.Show();
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            LlamarEliminar.Show();
            
        }

        private void buttonCorrecciones_Click(object sender, EventArgs e)
        {
            LlamarCorreciones.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
