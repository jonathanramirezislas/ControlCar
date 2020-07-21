using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VentanaPrincipal
{
    public partial class Cargas : Form
    {
        String[,] Matriz = new String[100, 7];
        String[,] Acorregir = new String[100, 7];
        DataSet dsResultados = new DataSet();
        Correciones LlamarCorreciones = new Correciones();
        Correciones Corregir = new Correciones();

        Conexion llamar = new Conexion();
        public Cargas()
        {
            InitializeComponent();
        }

        private void Cargas_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSeleccion_Click(object sender, EventArgs e)
        {
            string rutaarchivo = string.Empty;
            OpenFileDialog Direccion = new OpenFileDialog();

            if (Direccion.ShowDialog()==DialogResult.OK)
            {
               rutaarchivo = Direccion.FileName;
            }
            textBox1.Text=rutaarchivo;
        }

        private void buttonCarga_Click(object sender, EventArgs e)
        {
            string placasdecarrosqueestanenbaja=""; bool CARROSBAJAS = true;

            if (File.Exists("DatosNoCargados.txt"))
            {
                File.Delete("DatosNoCargados.txt");
            }
            TextWriter archivo;
            archivo = new StreamWriter("DatosNoCargados.txt");
            archivo.Close();
            StreamWriter escribir = File.AppendText("DatosNoCargados.txt");

            string datoscargados = " DATOS CARGADOS CORRECTAMENTE\n\n ";
            string datosNocargados = "DATOS QUE NO SE CARGARON\n\n";
            String cARROSquenOEXISTEN = "";bool EXISTENCIA = false;

                DataSet ds;
            int km = 0;
            string fecha;
            bool HuboErrores = true;
            ArchivoaMatriz();
            bool sihubocargas = false;
            string esnuevo;
            //Imprmir(Matriz);
            for (int indicefila = 0; indicefila < ReccorreHasta(); indicefila++)
            {
                DataSet TodosLoscarros;
                TodosLoscarros = llamar.CargaDatos("SELECT * from Automovil where Placas='" + Matriz[indicefila, 0] + "'");

                ////Par5ab saber si ya tenia cargas
                DataSet dsExiste;


                int TIENERELACION = 0;
                    dsExiste = llamar.CargaDatos("SELECT count(Placas) from CARGAS where Placas='" + Matriz[indicefila, 0] + "'");
                    TIENERELACION =Convert.ToUInt16( dsExiste.Tables[0].Rows[0][0].ToString());
                    
                    if (TIENERELACION!=0) { 
                    //para traer el ultimo registro
                        ds = llamar.CargaDatos(" SELECT * FROM Cargas  WHERE Placas ='"+Matriz[indicefila, 0] +"'AND UltimaCarga=1 ", "Cargas");
                string fecant = Convert.ToString(ds.Tables[0].Rows[0][2].ToString());
                string Fecact = Convert.ToString(Matriz[indicefila, 4]);  
                DateTime fecant1 = DateTime.ParseExact(fecant, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime Fecact1 = DateTime.ParseExact(Fecact, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                
                 int FECEMAYOR = DateTime.Compare(fecant1, Fecact1);
               
                double kmanterior = Convert.ToDouble(ds.Tables[0].Rows[0][4].ToString());
                double kmactual = Convert.ToDouble(Matriz[indicefila, 2]);
                   
                double LTgasolina = Convert.ToDouble(Matriz[indicefila, 3]);
                string FormaSentencia = string.Empty;
                string FormaSentencia2 = string.Empty;
                    //este if es para saber si esta activo
                        if (Convert.ToString(TodosLoscarros.Tables[0].Rows[0][7].ToString()).Equals("1"))
                    {
                        //Para que las fechas no sean menores ni los km a los registros anteriores
                        if ((kmactual>kmanterior) && (FECEMAYOR < 0))
                    { 

               
                                       
                        FormaSentencia = " insert into Cargas(cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,Kilometrajetotal,rendimiento,UltimaCarga,id_Provedor,Placas) Values(" + LTgasolina + "," + Matriz[indicefila, 5] + ",'"+ Matriz[indicefila, 4] + "',"+ (kmactual - kmanterior) + "," + Matriz[indicefila, 2] + "," + ((kmactual - kmanterior) / LTgasolina) + ",1,'" + Matriz[indicefila, 1] + "','" + Matriz[indicefila, 0] + "')";
                                FormaSentencia2 = "update Cargas set UltimaCarga=0 where Fecha_De_Cargayhora='"+fecant+ "'";
                            datoscargados += "Placas=" + Matriz[indicefila, 0] + " Provedor=" + Matriz[indicefila, 1] + " Km vehiculo=" + Matriz[indicefila, 2] + " Carga de litros=" + Matriz[indicefila, 3] + " Fecah y hora=" + Matriz[indicefila, 4] + " Monto=" + Matriz[indicefila, 5] + "\n\n";
                            sihubocargas = true;
                            if (llamar.EjecutaSentencia(FormaSentencia) == false)
                    { }  else {MessageBox.Show("Problemas con la base de datos."); }

                    
                            if (llamar.EjecutaSentencia(FormaSentencia2) == false)
                            { }
                            else { MessageBox.Show("Problemas con la base de datos."); }

                        }

                        ///se guardarn todos los datos no cargados por errores de km y fecha
                        else
                {
                    HuboErrores = false;
                   
                        escribir.WriteLine(Matriz[indicefila, 0]+";"+ Matriz[indicefila, 1]+";"+
                            Matriz[indicefila, 2]+";" + Matriz[indicefila, 3]+";"+ Matriz[indicefila, 4]+";"+
                            Matriz[indicefila, 5]);
                            datosNocargados+= "Placas="+Matriz[indicefila, 0] + " Provedor=" + Matriz[indicefila, 1] + " Km vehiculo=" + Matriz[indicefila, 2] + " Carga de litros=" + Matriz[indicefila, 3] + " Fecah y hora=" + Matriz[indicefila, 4] + " Monto=" + Matriz[indicefila, 5] + "\n\n";


                        }
                    }//aqui se guardan los carros donde estan dados de baja
                    else
                    {
                        CARROSBAJAS = false;
                        placasdecarrosqueestanenbaja = Matriz[indicefila, 0]+" ";
                        datosNocargados += "Placas=" + Matriz[indicefila, 0] + " Provedor=" + Matriz[indicefila, 1] + " Km vehiculo=" + Matriz[indicefila, 2] + " Carga de litros=" + Matriz[indicefila, 3] + " Fecah y hora=" + Matriz[indicefila, 4] + " Monto=" + Matriz[indicefila, 5] + "\n\n";

                    }

                }
                    //registro por primera carga 
                    else
                    {
                        string FormaSentencia2 = string.Empty;
                        FormaSentencia2 = " insert into Cargas(cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,Kilometrajetotal,rendimiento,UltimaCarga,id_Provedor,Placas) Values(" + Matriz[indicefila, 3] + "," + Matriz[indicefila, 5] + ",'" + Matriz[indicefila, 4] + "',0," + Matriz[indicefila, 2] + "," + 0 + ",1,'" + Matriz[indicefila, 1] + "','" + Matriz[indicefila, 0] + "')";
                    datoscargados += "Placas=" + Matriz[indicefila, 0] + " Provedor=" + Matriz[indicefila, 1] + " Km vehiculo=" + Matriz[indicefila, 2] + " Carga de litros=" + Matriz[indicefila, 3] + " Fecah y hora=" + Matriz[indicefila, 4] + " Monto=" + Matriz[indicefila, 5] + "\n\n";
                   



                    if (llamar.EjecutaSentencia(FormaSentencia2) == false)
                    {//para saber su hubo cargas y que se ejcuto correctamente la carga
                        sihubocargas = true;
                    }
                        else {
                        EXISTENCIA = true;
                        cARROSquenOEXISTEN += Matriz[indicefila, 0]+ " ,"; }

                    }

                }
               

            if (HuboErrores == false)  { MessageBox.Show("Algunos datos no se cargaron dirigase al boton corregir ");
                MessageBox.Show(datosNocargados);
                    buttonCorregir.Visible = true;

                } else if(CARROSBAJAS!=false && CARROSBAJAS != false) {
                    MessageBox.Show("TODOS LOS Datos se cargaron corrrectamente ");          
                }
                else
                {
                    MessageBox.Show("Hubo carros que no estan activos por lo tanto no se cargaron los datos");
                }

            if(sihubocargas==true)
            MessageBox.Show(datoscargados);

            if (CARROSBAJAS == false) MessageBox.Show("Comuniquese con el administrador para activar estos carros \n" + placasdecarrosqueestanenbaja);
            if (EXISTENCIA == true) MessageBox.Show("ESTOS CARROS NO EXISTEN (PLACAS) \n" + cARROSquenOEXISTEN);


            escribir.Close();

            
        }
        public void ArchivoaMatriz()
        {

            StreamReader leerlineas = new StreamReader(textBox1.Text);

            
            string line;
            int c = 0;
            int x = 0;
            while ((line = leerlineas.ReadLine()) != null)
            {
                string[] w;
                w = line.Split(';');
                x = 0;
                foreach (string A in w)
                {
                    Matriz[c, x] = A;
                    x++;
                }
                c++;
            }
            leerlineas.Close();
            
        }







        public void Imprmir(string[,] A)
        {

            int rows = A.GetUpperBound(0) - A.GetLowerBound(0) + 1;
            int cols = A.GetUpperBound(1) - A.GetLowerBound(1) + 1;

            string datos = "";
            for (int indicefila = 0; indicefila < rows; indicefila++)
            {


                for (int indicecol = 0; indicecol < cols; indicecol++)
                {
                   MessageBox.Show(A[indicefila, indicecol] + " ");

                }
                MessageBox.Show("");



            }
     
        }


        private void textBoxCorregir_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCorregir_Click(object sender, EventArgs e)
        {
            LlamarCorreciones.Show();
        }


        public int ReccorreHasta()
        {
            StreamReader leerlineas = new StreamReader(textBox1.Text);


            string line;
            int c = 0;
            int x = 0;
            while ((line = leerlineas.ReadLine()) != null)
            {
                string[] w;
                w = line.Split(';');
                x = 0;
                foreach (string A in w)
                {
                    Matriz[c, x] = A;
                    x++;
                }
                c++;
            }
            leerlineas.Close();
            return c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        

        }

        private void buttonCARGAS_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds;


                ds = llamar.CargaDatos("Select Placas,Po.nombre_Provedor,cargalitros,Monto_De_Carga,Fecha_De_Cargayhora,KilometrajeRecorrido,rendimiento,Kilometrajetotal FROM  Cargas Ca INNER JOIN Provedor Po on Ca.id_Provedor=Po.id_Provedor  ");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }
    }
}
