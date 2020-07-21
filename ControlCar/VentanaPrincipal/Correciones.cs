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
    public partial class Correciones : Form
    {
        
        string dirrecion = "";
        Conexion Llamar = new Conexion();
        int fila = 0;
        string[,] matrizAcorregir = new string[100, 6];
        public Correciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Correciones_Load(object sender, EventArgs e)
        {
            
            //formato
            dateTimePickerFechaAcoregir.Format = DateTimePickerFormat.Custom;
            dateTimePickerFechaAcoregir.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            ArchivoaMatriz();
            MOSTRARelcarro(matrizAcorregir[0, 0]);
            this.textBoxPlacas.Text = matrizAcorregir[0, 0];
            this.textBoxKm.Text = matrizAcorregir[0, 2];
            this.dateTimePickerFechaAcoregir.Text = matrizAcorregir[0, 4];
        }

        private void dateTimePickerFechaAcoregir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fila++;

                this.textBoxPlacas.Text = matrizAcorregir[fila, 0];
                this.textBoxKm.Text = matrizAcorregir[fila, 2];
                this.dateTimePickerFechaAcoregir.Text = matrizAcorregir[fila, 4];

            MOSTRARelcarro(matrizAcorregir[fila, 0]);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MatrizaArchivo();
            desactivarlabesytex();
            this.Hide();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
             matrizAcorregir[fila, 2] = textBoxKm.Text;
              matrizAcorregir[fila, 4] = dateTimePickerFechaAcoregir.Text;
            MessageBox.Show("Se han hecho las correciones");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fila--;
            if (fila >= 0) { 
            this.textBoxPlacas.Text = matrizAcorregir[fila,0];
            this.textBoxKm.Text = matrizAcorregir[fila, 2];
                this.dateTimePickerFechaAcoregir.Text = matrizAcorregir[fila, 4];
                MOSTRARelcarro(matrizAcorregir[fila, 0]);

            }
            else
            {
                MessageBox.Show("Estas en el comienzo");
            }
        }





        public void MatrizaArchivo(string[,] A)
        {
            if (File.Exists("Corregir.txt"))
            {
                File.Delete("Corregir.txt");
            }
            TextWriter archivo;
            archivo = new StreamWriter("Corregir.txt");
            archivo.Close();
            string infor = "";
            string aux = "";
            StreamWriter escribir = File.AppendText("Estudiantes.txt");
            int rows = A.GetUpperBound(0) - A.GetLowerBound(0) + 1;
            int cols = A.GetUpperBound(1) - A.GetLowerBound(1) + 1;
            for (int indicefila = 0; indicefila < rows; indicefila++)
            {   infor = null;
                aux = null;
                for (int indicecol = 0; indicecol < cols; indicecol++)
                {
                    if (A[indicefila, indicecol] != null)
                    {     infor += (A[indicefila, indicecol]) + ";";  } }
                if (infor != null && infor != null)
                {    aux = infor.Substring(0, ((infor.Length) - 1));   escribir.WriteLine(aux); }  }
              escribir.Close();
        }



        public void ArchivoaMatriz()
        {
            StreamReader leerlineas = new StreamReader("DatosNoCargados.txt");
            
            string line;      int c = 0;  int x = 0;
            while ((line = leerlineas.ReadLine()) != null)
            {     string[] w;
                w = line.Split(';');
                x = 0;
                foreach (string A in w)
                {   matrizAcorregir[c, x] = A;  x++; }
                c++;  }
            leerlineas.Close();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonsaalir_Click(object sender, EventArgs e)
        {
            this.Hide();

            desactivarlabesytex();
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            ArchivoaMatriz();
            
        }
        public void MatrizaArchivo()
        {try { 
            string guardao = dirrecion + "\\" + textBoxName.Text+".txt";
            if (File.Exists(guardao))
            {
                File.Delete(guardao);
            }
            TextWriter archivo;
            archivo = new StreamWriter(guardao);
            archivo.Close();
            string infor = "";

            string aux = "";
            StreamWriter escribir = File.AppendText(guardao);
        
            for (int indicefila = 0; indicefila < 100; indicefila++)
            {
                infor = null;
                aux = null;
                for (int indicecol = 0; indicecol < 6; indicecol++)
                {

                    if (matrizAcorregir[indicefila, indicecol] != null)
                    {
                        infor += (matrizAcorregir[indicefila, indicecol]) + ";";
                    }

                }
                if (infor != null && infor != null)
                {
                    aux = infor.Substring(0, ((infor.Length) - 1));
                    escribir.WriteLine(aux);
                }

                }
                MessageBox.Show("Se ha guardado el archivo");
                escribir.Close();

            }
            catch
            {
                MessageBox.Show("Error al guardar el archivo");
            }


        }

        private void buttonDireccion_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                dirrecion = fbd.SelectedPath;
                //  BrowseBackupBtn.Enabled = true;
            }
        }

        public void MOSTRARelcarro(string Placas)
        {

            try
            {
                DataSet ds;


                ds = Llamar.CargaDatos("SELECT Placas,Kilometrajetotal,Fecha_De_Cargayhora FROM Cargas WHERE Placas ='" + Placas+"' AND UltimaCarga=1");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Informacion incorrecta" + error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        public void activarlabesytex()
        {
            textBoxKm.Visible = true;
            textBoxName.Visible = true;
            textBoxPlacas.Visible = true;
            labelfecacorr.Visible = true;
            labelkm.Visible = true;
            labelplaca.Visible = true;
            buttoncorreg.Visible = true;
            buttonatrazar.Visible = true;
            buttonavanz.Visible = true;
            dateTimePickerFechaAcoregir.Visible = true;
        }
        public void desactivarlabesytex()
        {
            textBoxKm.Visible = false;
            textBoxName.Visible = false;
            textBoxPlacas.Visible = false;
            labelfecacorr.Visible = false;
            labelkm.Visible = false;
            labelplaca.Visible = false;
            buttoncorreg.Visible = false;
            buttonatrazar.Visible = false;
            buttonavanz.Visible = false;
            dateTimePickerFechaAcoregir.Visible = false;
        }
        public void inicicaracorregir()
        {
            ArchivoaMatriz();
            MOSTRARelcarro(matrizAcorregir[0, 0]);
            this.textBoxPlacas.Text = matrizAcorregir[0, 0];
            this.textBoxKm.Text = matrizAcorregir[0, 2];
            this.dateTimePickerFechaAcoregir.Text = matrizAcorregir[0, 4];
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            Array.Clear(matrizAcorregir, 0, matrizAcorregir.Length);
            inicicaracorregir();
            activarlabesytex();
        }
    }
}
