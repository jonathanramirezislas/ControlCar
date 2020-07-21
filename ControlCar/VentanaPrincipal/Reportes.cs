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
    public partial class Reportes : Form
    {
        
        DataSet dsResultados = new DataSet();


        Conexion Llamar = new Conexion();
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            dateTimePickerFecInic.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecInic.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dateTimePickerFecFina.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecFina.CustomFormat = "dd/MM/yyyy hh:mm:ss";

          
        }

        private void buttonAutoACTIVOS_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("Select Placas,Ma.nombre_Marca,Modelo,Co.nombre_color,Año_de_Fabricacion,Ti.nombre_Tipo,activo from Automovil Au INNER JOIN Marca Ma on Au.id_Marca=Ma.id_Marca"
                                                   + " Inner join Tipo Ti on Au.id_Tipo = Ti.id_Tipo Inner join color Co on Au.id_color = Co.id_color Where activo = 1");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta " + error);
            }
        }

        private void buttonAutoDesac_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("Select Placas,Ma.nombre_Marca,Modelo,Co.nombre_color,Año_de_Fabricacion,Ti.nombre_Tipo,activo from Automovil Au INNER JOIN Marca Ma on Au.id_Marca=Ma.id_Marca"
                                                    + " Inner join Tipo Ti on Au.id_Tipo = Ti.id_Tipo Inner join color Co on Au.id_color = Co.id_color Where activo = 0");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;

                ds = Llamar.CargaDatos(" select Placas,Po.nombre_Provedor,Monto_De_Carga,cargalitros,Fecha_De_Cargayhora,Kilometrajetotal,KilometrajeRecorrido,rendimiento FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor where   UltimaCarga =1 AND rendimiento >=" + textBoxRend.Text + " AND  Fecha_De_Cargayhora   between '" + dateTimePickerFecInic.Text + "' and  '" + dateTimePickerFecFina.Text + "' ");

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void textBoxFceFin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos(" select Placas,Po.nombre_Provedor,Monto_De_Carga,cargalitros,Fecha_De_Cargayhora,Kilometrajetotal,KilometrajeRecorrido,rendimiento FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor  WHERE   UltimaCarga =1 AND rendimiento <=" + textBoxRend.Text+" AND  Fecha_De_Cargayhora   between '" + dateTimePickerFecInic.Text+"' and  '"+dateTimePickerFecFina.Text+"' ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
           

        }

        private void buttonAutomoviles_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("Select Placas,Po.nombre_Provedor,cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento,Kilometrajetotal FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor where Placas='" + textBoxPlacas.Text+ "' Order By Fecha_De_Cargayhora Desc");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCARGAS_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("Select Placas,Po.nombre_Provedor,cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento,Kilometrajetotal FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor  ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
    }
}
