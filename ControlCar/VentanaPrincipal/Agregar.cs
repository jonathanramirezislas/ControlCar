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

    public partial class Agregar : Form
    {

        DataSet dsResultados = new DataSet();
        
        Conexion Llamar= new Conexion();

        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrarvalidaciones();
            if(validacion())
            {
                string FormaSentencia = string.Empty;
            FormaSentencia= " insert into Automovil(Placas, Modelo, Año_de_Fabricacion, Precio,Num_Puertas,Num_Cilidros,lujo,activo, id_color, id_Marca, id_Tipo)  values('" + textBoxPlacas.Text+"', '"+textBoxmodelo.Text+"','"+textBoxaño.Text+"', '"+textBoxprecio.Text+"',"+textBoxNumPuertas.Text+","+textBoxNumCilidnros.Text+",'"+comboBoxLujo.Text+"',"+1+", '"+comboBoxColor.SelectedValue+"', '"+comboBoxMarca.SelectedValue+"', '"+comboBoxTipoVehiculo.SelectedValue+"');";

            if (Llamar.EjecutaSentencia(FormaSentencia) == false)
            {
                MessageBox.Show("El carro  se ha agregado.");
                    LImpirartexbox();
            }
            else
            {
                MessageBox.Show("Problemas con la base de datos.");
            }
            }

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            dsResultados = Llamar.CargaDatos("Select * From color Order By nombre_color", "color");
            comboBoxColor.DataSource = dsResultados.Tables["color"];
            comboBoxColor.DisplayMember = dsResultados.Tables["color"].Columns["nombre_color"].ToString();
            comboBoxColor.ValueMember = "id_color";

            dsResultados = Llamar.CargaDatos("Select * From Marca Order By id_Marca", "Marca");
            comboBoxMarca.DataSource = dsResultados.Tables["Marca"];
            comboBoxMarca.DisplayMember = dsResultados.Tables["Marca"].Columns["nombre_Marca"].ToString();
            comboBoxMarca.ValueMember = "id_Marca";

            dsResultados = Llamar.CargaDatos("Select * From Tipo Order By nombre_Tipo", "Tipo");
            comboBoxTipoVehiculo.DataSource = dsResultados.Tables["Tipo"];
            comboBoxTipoVehiculo.DisplayMember = dsResultados.Tables["Tipo"].Columns["nombre_Tipo"].ToString();
            comboBoxTipoVehiculo.ValueMember = "id_Tipo";

            

            comboBoxLujo.Items.Add("SI");
            comboBoxLujo.Items.Add("NO");
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        public bool validacion()
        {
            bool validar = true;
            if (textBoxPlacas.Text == "")
            {
                validar = false;
                errorProvider1.SetError(textBoxPlacas, "Ingrese las placas porfavor");
            }
           
            
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
            errorProvider1.SetError(textBoxPlacas, "");
            errorProvider1.SetError(textBoxaño, "");
            errorProvider1.SetError(textBoxprecio, "");
            errorProvider1.SetError(textBoxNumCilidnros, "");
            errorProvider1.SetError(textBoxNumPuertas, "");
            errorProvider1.SetError(comboBoxLujo, "");
            errorProvider1.SetError(textBoxmodelo, "");

            
        }
        public void LImpirartexbox()
        {
            textBoxaño.Text = "";
            textBoxmodelo.Text = "";
            textBoxNumCilidnros.Text = "";
            textBoxNumPuertas.Text = "";
            textBoxPlacas.Text = "";
            textBoxprecio.Text = "";
            
        }
    }
}
