using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios.Interfaces
{
    interface ITAutor
    {
        DataSet Listar();
        string[] Agregar(TAutor autor);
        string[] Eliminar(string codAutor);
        string[] Actualizar(TAutor autor);
        DataSet Buscar(string busqueda);
    }
}
