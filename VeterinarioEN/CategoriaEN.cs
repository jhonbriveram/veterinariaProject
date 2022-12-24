using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{

        [DataContract]
        public class CategoriaEN : BaseEN
        {
            [DataMember]
            public int iIdCategoria { get; set; }
            [DataMember]
            public string sNombre { get; set; }
        }
    
}
