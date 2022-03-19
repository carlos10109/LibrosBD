using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosSW.Cliente.Model
{
    public class Libros
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string FechaLanzamiento { get; set; }
        public int Autor { get; set; }
        public int Categoria { get; set; }
        public int Editorial { get; set; }
        public string Idioma { get; set; }
        public string Descripcion { get; set; }
    }
}
