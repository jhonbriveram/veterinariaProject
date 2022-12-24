using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class ServiciosEN
    {
        [DataMember]
        public int iIdServicios { get; set; }
        [DataMember]
        public string sNombreServicio { get; set; }
        [DataMember]
        public string sCaracteristicas { get; set; }
        [DataMember]
        public decimal dPrecio { get; set; }

    }
}
