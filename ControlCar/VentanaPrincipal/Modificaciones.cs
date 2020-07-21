using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace VentanaPrincipal
{
    public partial class Modificaciones : Form
    {
        DataSet dsResultados = new DataSet();

      

        Conexion llamar = new Conexion();
        public Modificaciones()
        {
            InitializeComponent();
        }

        private void buttonDesplegar_Click(object sender, EventArgs e)
        {
            DataSet ds;
            ds = llamar.CargaDatos("Select * FROM Automovil Where  Placas = '" + textBoxPlacas.Text + "'", "Automovil");


            DataSet dsColor;
            dsColor = llamar.CargaDatos("Select * FROM color where id_color='" + ds.Tables[0].Rows[0]["id_color"].ToString() + "'", "color");

            DataSet dsMarca;
            dsMarca = llamar.CargaDatos("Select * FROM Marca where id_Marca='" + ds.Tables[0].Rows[0]["id_Marca"].ToString() + "'", "Marca");

            DataSet dsTipo;
            dsTipo = llamar.CargaDatos("Select * FROM Tipo where id_Tipo='" + ds.Tables[0].Rows[0]["id_Tipo"].ToString() + "'", "Tipo");

            


            
            this.textBoxmodelo.Text = ds.Tables[0].Rows[0][1].ToString();
           
            this.textBoxaño.Text = ds.Tables[0].Rows[0][2].ToString();
            this.textBoxprecio.Text = ds.Tables[0].Rows[0][3].ToString();
            this.textBoxNumPuertas.Text = ds.Tables[0].Rows[0][4].ToString();
            this.textBoxNumCilidnros.Text = ds.Tables[0].Rows[0][5].ToString();

            comboBoxLujo.Text = ds.Tables[0].Rows[0][6].ToString();
            comboBoxActivo.Text=ds.Tables[0].Rows[0][7].ToString();
            comboBoxColor.Text = dsColor.Tables[0].Rows[0][1].ToString();
            comboBoxMarca.Text = dsMarca.Tables[0].Rows[0][1].ToString();
          
        }

        private void Modificaciones_Load(object sender, EventArgs e)
        {
            

            dsResultados = llamar.CargaDatos("Select * From color Order By nombre_color", "color");
            comboBoxColor.DataSource = dsResultados.Tables["color"];
            comboBoxColor.DisplayMember = dsResultados.Tables["color"].Columns["nombre_color"].ToString();
            comboBoxColor.ValueMember = "id_color";

            dsResultados = llamar.CargaDatos("Select * From Marca Order By nombre_Marca", "Marca");
            comboBoxMarca.DataSource = dsResultados.Tables["Marca"];
            comboBoxMarca.DisplayMember = dsResultados.Tables["Marca"].Columns["nombre_Marca"].ToString();
            comboBoxMarca.ValueMember = "id_Marca";

            dsResultados = llamar.CargaDatos("Select * From Tipo Order By nombre_Tipo", "Tipo");
            comboBoxTipoVehiculo.DataSource = dsResultados.Tables["Tipo"];
            comboBoxTipoVehiculo.DisplayMember = dsResultados.Tables["Tipo"].Columns["nombre_Tipo"].ToString();
            comboBoxTipoVehiculo.ValueMember = "id_Tipo";

            comboBoxLujo.Items.Add("SI");
            comboBoxLujo.Items.Add("NO");
            comboBoxActivo.Items.Add(1);
            comboBoxActivo.Items.Add(0);
        }

        private void comboBoxPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

            string FormaSentencia = string.Empty;
            FormaSentencia = " update Automovil set Modelo='" + textBoxmodelo.Text + "',Año_de_Fabricacion=" + textBoxaño.Text + ",Precio='" + textBoxprecio.Text + "',Num_Puertas=" + textBoxNumPuertas.Text + ",Num_Cilidros="+textBoxNumCilidnros.Text+ ",lujo='"+comboBoxLujo.Text+ "', id_color='"+comboBoxColor.SelectedValue+"', id_Marca='"+comboBoxMarca.SelectedValue+ "',activo="+comboBoxActivo.Text+", id_Tipo='" + comboBoxTipoVehiculo.SelectedValue+"' Where Placas='" + textBoxPlacas.Text + "'";

            if (llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("Los cambios se han realizado.");
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos no modificados checar datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
      

        }
        public bool validacion()
        {
            bool validar = true;
           
          

            if (textBoxNumPuertas.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxNumPuertas, "Ingrese los Num Puertas porfavor");
            }
            if (textBoxprecio.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxprecio, "Ingrese los Precio porfavor");
            }
            if (textBoxNumCilidnros.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxNumCilidnros, "Ingrese los Num Cilindros porfavor");
            }
            if (textBoxaño.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxaño, "Ingrese los Año del carro porfavor");
            }
            if (textBoxmodelo.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxmodelo, "Ingrese los modelo del carro porfavor");
            }


            return validar;
        }
        public void Borrarvalidaciones()
        {
            
            errorProvider1.SetError(textBoxaño, "");
            errorProvider1.SetError(textBoxprecio, "");
            errorProvider1.SetError(textBoxNumCilidnros, "");
            errorProvider1.SetError(textBoxNumPuertas, "");
            errorProvider1.SetError(comboBoxLujo, "");
           
            errorProvider1.SetError(textBoxmodelo, "");


        }

        private void comboBoxActivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
