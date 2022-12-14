//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistarVentas
{
    using System;
    using System.Collections.Generic;
    
    public partial class venta
    {
        public venta()
        {
            this.CXC = new HashSet<CXC>();
            this.detalleVenta = new HashSet<detalleVenta>();
            this.reparacion = new HashSet<reparacion>();
        }
    
        public int idventa { get; set; }
        public Nullable<int> idcliente { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> usuario { get; set; }
        public Nullable<double> monto { get; set; }
        public Nullable<int> metodo { get; set; }
        public Nullable<double> efectivo { get; set; }
        public Nullable<double> tarjeta { get; set; }
        public Nullable<double> descuento { get; set; }
        public Nullable<double> credito { get; set; }
        public Nullable<double> subtotal { get; set; }
        public Nullable<double> itebis { get; set; }
        public Nullable<double> devuelta { get; set; }
        public string estado { get; set; }
        public string vendedor { get; set; }
        public string ncf { get; set; }
        public string rnc { get; set; }
        public string cliente { get; set; }
        public string tipodocumento { get; set; }
        public Nullable<double> totalItbis { get; set; }
        public Nullable<System.DateTime> Fecha_vencimiemto_comprobante { get; set; }
    
        public virtual Cliente Cliente1 { get; set; }
        public virtual ICollection<CXC> CXC { get; set; }
        public virtual ICollection<detalleVenta> detalleVenta { get; set; }
        public virtual login login { get; set; }
        public virtual Metodo_de_Pago Metodo_de_Pago { get; set; }
        public virtual ICollection<reparacion> reparacion { get; set; }
    }
}
