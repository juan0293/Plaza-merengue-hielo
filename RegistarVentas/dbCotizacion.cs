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
    
    public partial class dbCotizacion
    {
        public int idcotiza { get; set; }
        public string cliente { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<bool> estado { get; set; }
        public string rnc { get; set; }
        public Nullable<double> totalItbis { get; set; }
    }
}
