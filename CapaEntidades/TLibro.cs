using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class TLibro
    {
        private string codLibro;
        private string titulo;
        private string editorial;

        public string CodLibro { get => codLibro; set => codLibro = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
    }
}

