using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Interfaces
{
   interface ITPrestamo
    {
        DataSet Listar();
        string[] Agregar(TPrestamo prestamo);
        string[] Eliminar(TPrestamo prestamo);
        DataSet Buscar(string busqueda);
    }
}
