//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_de_Facturacion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class venta
    {
        public int id { get; set; }
        public Nullable<int> cantidad { get; set; }
        public Nullable<int> idProducto { get; set; }
        public Nullable<int> idFactura { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
