using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class MascotaEN
    {

        [DataMember]
        public int iIdMascota { get; set; }

        [DataMember]
        public string sNombreMascota { get; set; }

        [DataMember]
        public DateTime dFechaNacimiento { get; set; }

        [DataMember]
        public string sPeso { get; set; }

        [DataMember]
        public string sEdad { get; set; }

        [DataMember]
        public string sColor { get; set; }

        [DataMember]
        public string sRaza { get; set; }

        [DataMember]
        public string sImagen { get; set; }
    }
}
