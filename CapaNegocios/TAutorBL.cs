using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class TAutorBL : Interfaces.ITAutor
    {
        //Datos datos = new DatosMySQL();
        MySqlDatos datos = new MySqlDatos();
        public string[] Actualizar(TAutor autor)
        {
            string[] parametros = { autor.CodAutor, autor.Apellidos, autor.Nombres, autor.Nacionalidad };
            DataRow datosres = datos.TraerDataRow("procActualizarAutor", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public string[] Agregar(TAutor autor)
        {
            string[] parametros = { autor.CodAutor, autor.Apellidos, autor.Nombres, autor.Nacionalidad };
            DataRow datosres = datos.TraerDataRow("procAgregarAutor", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Buscar(string busqueda)
        {
            return datos.Ejecutar("procBuscarAutor", new string[] { busqueda });
        }

        public string[] Eliminar(string codAutor)
        {
            DataRow datosres = datos.TraerDataRow("procEliminarAutor", new string[]{ codAutor });
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Listar()
        {
            return datos.Listar("procListarAutor");
        }
    }
}
