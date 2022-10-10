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
    public class TPrestamoBL : Interfaces.ITPrestamo
    {
        MySqlDatos datos = new MySqlDatos();

        public string[] Agregar(TPrestamo prestamo)
        {
            string[] parametros = { prestamo.CodLibro, prestamo.CodAutor, prestamo.FechaPrestamo };
            DataRow datosres = datos.TraerDataRow("procAgregarPrestamo", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Buscar(string busqueda)
        {
            return datos.Ejecutar("procBuscarPrestamo", new string[] { busqueda });
        }

        public string[] Eliminar(TPrestamo prestamo)
        {
            string[] parametros = { prestamo.CodLibro, prestamo.CodAutor, prestamo.FechaPrestamo };
            DataRow datosres = datos.TraerDataRow("procEliminarPrestamo", parametros);
            return new string[] { datosres.ItemArray[0].ToString(), datosres.ItemArray[1].ToString() };
        }

        public DataSet Listar()
        {
            return datos.Listar("procListarPrestamo");
        }
    }
}
