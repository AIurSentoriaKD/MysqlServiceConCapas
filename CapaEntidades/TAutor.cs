using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TAutor
    {
        private string codAutor;
        private string apellidos;
        private string nombres;
        private string nacionalidad;

        public string CodAutor { get => codAutor; set => codAutor = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
