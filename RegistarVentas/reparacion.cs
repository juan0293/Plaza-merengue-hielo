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
    
    public partial class reparacion
    {
        public int idtrabajo { get; set; }
        public Nullable<int> empledoid { get; set; }
        public Nullable<int> ventaid { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<double> monto { get; set; }
    
        public virtual empleado empleado { get; set; }
        public virtual venta venta { get; set; }
    }
}
