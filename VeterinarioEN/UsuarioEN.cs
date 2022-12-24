using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class UsuarioEN : BaseEN
    {
        [DataMember]
        public int iIdUsuario { get; set; }
        [DataMember]
        public string sLogin { get; set; }
        [DataMember]
        public string sPassWord { get; set; }
        [DataMember]
        public string sNombres { get; set; }
        [DataMember]
        public string sApellidos { get; set; }
        [DataMember]
        public string sDireccion { get; set; }
        [DataMember]
        public string sObservacion { get; set; }
        [DataMember]
        public TipoUsuarioEN idTipoUsuario { get; set; }
    }
}
