using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Interfaces
{
    interface ITLibro
    {
        DataSet Listar();
        string[] Agregar(TLibro libro);
        string[] Eliminar(string codLibro);
        string[] Actualizar(TLibro libro);
        DataSet Buscar(string busqueda);
    }
}
