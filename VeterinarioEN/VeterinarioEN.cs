using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class VeterinarioEN
    {
        [DataMember]
        public int iIdVeterinario { get; set; }

        [DataMember]
        public string sNombreVeterinario {get;set;}

        [DataMember]
        public string sApellidoVeterinario { get; set; }

        [DataMember]
        public string sDireccion { get; set;  }

        [DataMember]
        public string sTelefono { get; set; }
        [DataMember]
        public string sEspecialidad { get; set; }
        [DataMember]
        public string sFoto { get; set; }
    }
}
