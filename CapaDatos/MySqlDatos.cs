using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MySqlDatos
    {
        private MySqlConnection mySqlConnection;
        private MySqlDataAdapter mySqlDataAdapter;
        private MySqlCommand mySqlCommand;
        private DataSet resultDataset;
        private DataTable resultTable;
        private string tabla, procedimiento, errormsj;
        private static string Cadena= ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        public void procComposed(String procedimientoAlmacenado, string[] parametros)
        {
            if (procedimientoAlmacenado == "procAgregarAutor" || procedimientoAlmacenado == "procActualizarAutor")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodAutor", parametros[0]);
                mySqlCommand.Parameters.AddWithValue("@inApellidos", parametros[1]);
                mySqlCommand.Parameters.AddWithValue("@inNombres", parametros[2]);
                mySqlCommand.Parameters.AddWithValue("@inNacionalidad", parametros[3]);
            }
            else if (procedimientoAlmacenado == "procAgregarLibro" || procedimientoAlmacenado == "procActualizarLibro")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodLibro", parametros[0]);
                mySqlCommand.Parameters.AddWithValue("@inTitulo", parametros[1]);
                mySqlCommand.Parameters.AddWithValue("@inEditorial", parametros[2]);
            }
            else if (procedimientoAlmacenado == "procAgregarPrestamo")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodLibro", parametros[0]);
                mySqlCommand.Parameters.AddWithValue("@inCodAutor", parametros[1]);
                mySqlCommand.Parameters.AddWithValue("@inFechaPrestamo", parametros[2]);
            }
            else if (procedimientoAlmacenado == "procEliminarAutor")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodAutor", parametros[0]);
            }
            else if (procedimientoAlmacenado == "procEliminarLibro")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodLibro", parametros[0]);
            }
            else if (procedimientoAlmacenado == "procEliminarPrestamo")
            {
                mySqlCommand.Parameters.AddWithValue("@inCodLibro", parametros[0]);
                mySqlCommand.Parameters.AddWithValue("@inCodAutor", parametros[1]);
                mySqlCommand.Parameters.AddWithValue("@inFechaPrestamo", parametros[2]);
            }else if (procedimientoAlmacenado.StartsWith("procBuscar"))
            {
                mySqlCommand.Parameters.AddWithValue("@busqueda", parametros[0]);
            }
        }
        public DataSet Ejecutar(String procedimientoAlmacenado, string[] parametros)
        {
            mySqlConnection = new MySqlConnection(Cadena);
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(procedimientoAlmacenado, mySqlConnection);
            mySqlCommand.CommandType = CommandType.StoredProcedure;
            
            procComposed(procedimientoAlmacenado, parametros);

            MySqlDataAdapter msds = new MySqlDataAdapter(mySqlCommand);

            resultDataset = new DataSet();
            msds.Fill(resultDataset);

            mySqlConnection.Close();
            mySqlConnection.Dispose();

            return resultDataset;

        }
        public DataSet Listar(String procedimientoAlmacenado)
        {
            mySqlConnection = new MySqlConnection(Cadena);
            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(procedimientoAlmacenado, mySqlConnection);
            mySqlCommand.CommandType = CommandType.StoredProcedure;


            MySqlDataAdapter msds = new MySqlDataAdapter(mySqlCommand);

            resultDataset = new DataSet();
            msds.Fill(resultDataset);

            mySqlConnection.Close();
            mySqlConnection.Dispose();

            return resultDataset;
        }

        public DataRow TraerDataRow(String procedimientoAlmacenado, string[] parametros)
        {
            return Ejecutar(procedimientoAlmacenado, parametros).Tables[0].Rows[0];
        }
    }
}
