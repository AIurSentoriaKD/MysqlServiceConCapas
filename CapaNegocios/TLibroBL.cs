using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class TLibroBL : Interfaces.ITLibro
    {
        //Datos datos = new DatosMySQL();  
        MySqlDatos datos = new MySqlDatos();
        public string[] Actualizar(TLibro libro)
        {
            string [] parametros = {libro.CodLibro,libro.Titulo,libro.Editorial};
            DataRow datosres = datos.TraerDataRow("procActualizarLibro", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public string[] Agregar(TLibro libro)
        {
            string[] parametros = { libro.CodLibro, libro.Titulo, libro.Editorial };
            DataRow datosres = datos.TraerDataRow("procAgregarLibro", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Buscar( string busqueda )
        {
            return datos.Ejecutar("procBuscarLibro",new string[] { busqueda });
        }

        public string[] Eliminar(string codLibro)
        {
            DataRow datosres = datos.TraerDataRow("procEliminarLibro", new string[] { codLibro });
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Listar()
        {
            return datos.Listar("procListarLibro");
        }
    }
}
