using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTK_FileManager
{
    public enum publico { Interno, Externo}
    public enum idioma { Español, Alemán, Francés, Portugúes}
    public enum clase { Documento, HojaDeCálculo, Presentación, GráficosYDiagramas, Videos, Ingeniería}
    public enum aprobacion { Borrador, Aprobado}
   
    public class FileParts
    {
        public publico Publico { get; set; }
        public idioma Idioma { get; set; }
        public string Puesto { get; set; }
        public string Tipo { get; set; }
        public string Titulo { get; set; }
        public aprobacion Aprobacion { get; set; }
        public int Version { get; set; }
    }
}
