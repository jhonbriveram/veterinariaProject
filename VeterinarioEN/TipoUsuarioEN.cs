using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class TipoUsuarioEN
    {
      
        [DataMember]
        public int iTipoUsuario { get; set; }
        [DataMember]
        public string sTipoUsuario { get; set; }
    }
}
