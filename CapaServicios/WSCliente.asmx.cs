using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using CapaNegocios;
using CapaEntidades;
namespace CapaServicios
{
    /// <summary>
    /// Descripción breve de WSCliente
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSCliente : System.Web.Services.WebService
    {

        [WebMethod(Description ="Listar la tabla autor")]
        public DataSet ListarAutor()
        {
            TAutorBL autorBL = new TAutorBL();
            return autorBL.Listar();
        }

        [WebMethod(Description = "Buscar en la tabla autor")]
        public DataSet BuscarAutor(string busqueda)
        {
            TAutorBL autorBL = new TAutorBL();
            return autorBL.Buscar(busqueda);
        }

        [WebMethod(Description = "Agregar autor")]
        public string[] AgregarAutor(string codAutor, string nombres, string apellidos, string nacionalidad)
        {
            TAutorBL autorBL = new TAutorBL();
            TAutor autor = new TAutor
            {
                CodAutor = codAutor,
                Nombres = nombres,
                Apellidos = apellidos,
                Nacionalidad = nacionalidad
            };
            return autorBL.Agregar(autor);
        }
        [WebMethod(Description = "Actualizar autor")]
        public string[] ActualizarAutor(string codAutor, string nombres, string apellidos, string nacionalidad)
        {
            TAutorBL autorBL = new TAutorBL();
            TAutor autor = new TAutor
            {
                CodAutor = codAutor,
                Nombres = nombres,
                Apellidos = apellidos,
                Nacionalidad = nacionalidad
            };
            return autorBL.Actualizar(autor);
        }
        [WebMethod(Description = "Eliminar Autor")]
        public string[] EliminarAutor(string codautor)
        {
            TAutorBL autorBL = new TAutorBL();
            return autorBL.Eliminar(codautor);
        }

        #region TLIBRO

        [WebMethod(Description = "Listar la tabla libro")]
        public DataSet ListarLibro()
        {
            TLibroBL libroBL = new TLibroBL();
            return libroBL.Listar();
        }

        [WebMethod(Description = "Buscar en la tabla libro")]
        public DataSet BuscarLibro(string busqueda)
        {
            TLibroBL libroBL = new TLibroBL();
            return libroBL.Buscar( busqueda);
        }

        [WebMethod(Description = "Agregar Libro")]
        public string[] AgregarLibro(string codLibro, string titulo, string editorial)
        {
            TLibroBL libroBL = new TLibroBL();
            TLibro libro = new TLibro
            {
                CodLibro = codLibro,
                Titulo = titulo,
                Editorial = editorial
            };
            return libroBL.Agregar(libro);
        }

        [WebMethod(Description = "Actualizar Libro")]
        public string[] ActualizarLibro(string codLibro, string titulo, string editorial)
        {
            TLibroBL libroBL = new TLibroBL();
            TLibro libro = new TLibro
            {
                CodLibro = codLibro,
                Titulo = titulo,
                Editorial = editorial
            };
            return libroBL.Actualizar(libro);
        }

        [WebMethod(Description = "Eliminar Libro")]
        public string[] EliminarLibro(string codlibro)
        {
            TLibroBL libroBL = new TLibroBL();
            return libroBL.Eliminar(codlibro);
        }

        #endregion

        #region TPRESTAMO
        [WebMethod(Description = "Listar la tabla prestamo")]
        public DataSet ListarPrestamo()
        {
            TPrestamoBL prestamoBL = new TPrestamoBL();
            return prestamoBL.Listar();
        }

        [WebMethod(Description = "Buscar en la tabla prestamo")]
        public DataSet BuscarPrestamo(string busqueda)
        {
            TPrestamoBL prestamoBL = new TPrestamoBL();
            return prestamoBL.Buscar(busqueda);
        }

        [WebMethod(Description = "Agregar Prestamo")]
        public string[] AgregarPrestamo(string codAutor, string codLibro, string fechaPrestamo)
        {
            TPrestamoBL prestamoBL = new TPrestamoBL();
            TPrestamo prestamo = new TPrestamo
            {
                CodAutor = codAutor,
                CodLibro = codLibro,
                FechaPrestamo = fechaPrestamo
            };
            return prestamoBL.Agregar(prestamo);
        }

        [WebMethod(Description = "Eliminar Prestamo")]
        public string[] EliminarPrestamo(string codAutor, string codLibro, string fechaPrestamo)
        {
            TPrestamoBL prestamoBL = new TPrestamoBL();
            TPrestamo prestamo = new TPrestamo
            {
                CodAutor = codAutor,
                CodLibro = codLibro,
                FechaPrestamo = fechaPrestamo
            };
            return prestamoBL.Eliminar(prestamo);
        }
        #endregion
    }
}
