using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Tipo De Documento")]
        public TipoDocumento TipoDocumento { get; set; }
        public int Documento { get; set; }

        [DisplayName("Estado Civil")]
        public EstadoCivil EstadoCivil { get; set; }

        public int Sexo { get; set; }
        public bool Fallecio { get; set; } = false;
    }
}
