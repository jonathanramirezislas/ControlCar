using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;

namespace VentanaPrincipal
{
    class Conexion
    {
        private string conexion;
        SqlConnection bdCon;
        SqlCommand Comando;
        SqlDataAdapter daEjecuta;
        DataSet dsConjunto;

        public string Conetion()
        {

            return "Data Source=.;Initial Catalog=EmpresaDeVehiculosJONAS;Integrated Security=True";
          
        }

        public bool EjecutaSentencia(string paramSentencia)
        {
            bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            bool Flag = false;
            try
            {
                bdCon.ConnectionString = Conetion();
                if (bdCon.State == ConnectionState.Closed)
                {
                    bdCon.Open();
                }
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = paramSentencia;
                Comando.Connection = bdCon;
                Comando.ExecuteNonQuery();
                Flag = false;
            }
            catch (SqlException ex)
            {
                Flag = true;
                MessageBox.Show("Error al ejecutar sentencia. " + ex.Message);
            }
            finally
            {
                bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return Flag;
        }

        public DataSet CargaDatos(string paramCriterio, string Tabla)
        {
            bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            dsConjunto = new DataSet();
            try
            {
                bdCon.ConnectionString = Conetion();
                if (bdCon.State == ConnectionState.Closed)
                {
                    bdCon.Open();
                }
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = paramCriterio;
                Comando.Connection = bdCon;
                daEjecuta.SelectCommand = Comando;
                daEjecuta.Fill(dsConjunto, Tabla);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return dsConjunto;
        }



        public DataSet CargaDatos(string paramCriterio)
        {
            bdCon = new SqlConnection();
            Comando = new SqlCommand();
            daEjecuta = new SqlDataAdapter();
            dsConjunto = new DataSet();
            try
            {
                bdCon.ConnectionString = Conetion();
                if (bdCon.State == ConnectionState.Closed)
                {
                    bdCon.Open();
                }
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = paramCriterio;
                Comando.Connection = bdCon;
                daEjecuta.SelectCommand = Comando;
                daEjecuta.Fill(dsConjunto, "tabla");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                bdCon.Close();
                Comando.Dispose();
                daEjecuta.Dispose();
            }
            return dsConjunto;
        }

    }
}
