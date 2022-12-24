using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace VeterinarioEN
{
    [DataContract]
    public class ProductoEN
    {
        [DataMember]
        public int iIdProducto { get; set; }
        [DataMember]
        public string sNombreProducto { get; set; }
        [DataMember]
        public decimal dPrecio { get; set; }
        [DataMember]
        public CategoriaEN  IdCategoria { get; set;}
        [DataMember]
        public string sImagen { get; set; }
    }
}
