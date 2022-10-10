using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TPrestamo
    {
        private string codAutor;
        private string codLibro;
        private string fechaPrestamo;

        public string CodAutor { get => codAutor; set => codAutor = value; }
        public string CodLibro { get => codLibro; set => codLibro = value; }
        public string FechaPrestamo { get => fechaPrestamo; set => fechaPrestamo = value; }
    }
}
