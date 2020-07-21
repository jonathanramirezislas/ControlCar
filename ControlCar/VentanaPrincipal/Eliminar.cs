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
    public partial class Eliminar : Form
    {
        DataSet dsResultados = new DataSet();
        
        Conexion Llamar = new Conexion();
        public Eliminar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet ds;
            DataSet dsExiste;
            string TIENERELACION = "";
            ds = Llamar.CargaDatos("Select Placas,Ma.nombre_Marca,Ti.nombre_Tipo from Automovil Au INNER JOIN Marca Ma on Au.id_Marca=Ma.id_Marca"
                                                   + " Inner join Tipo Ti on Au.id_Tipo = Ti.id_Tipo Where Placas = '" + textBoxPlacas.Text + "'", "Automovil");
            dsExiste = Llamar.CargaDatos("SELECT count(Placas) from CARGAS where Placas='"+ textBoxPlacas.Text + "'");
            TIENERELACION= dsExiste.Tables[0].Rows[0][0].ToString();
            dataGridView1.DataSource = ds.Tables[0];


            DialogResult result = MessageBox.Show("Seguro que desea elimnar?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    if ( TIENERELACION.Equals("0"))
            {
                MessageBox.Show("El carro es de nuevo ingreso ya que no tiene algunos datos como son la cargas");
                MessageBox.Show("Se hizo baja fisica");
                string sentencia1 = string.Empty;
                    sentencia1 = "Delete From Automovil Where Placas = '" + textBoxPlacas.Text + "'";
                    Llamar.EjecutaSentencia(sentencia1);
            }
            else
            {
                MessageBox.Show("El carro tiene ya tiene registros");
                MessageBox.Show("Se hizo baja logica");
                string sentencia2 = string.Empty;
                    sentencia2 = " update Automovil set activo=" + 0+" Where Placas='"+ textBoxPlacas.Text+"'";
                    Llamar.EjecutaSentencia(sentencia2);

                }
                }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }
            this.Hide();

        }
        public void mostrardatos()
        {
            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("Select * FROM Automovil  WHERE Placas ='" + textBoxPlacas.Text + "'", "Automovil");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }

        private void comboBoxPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
