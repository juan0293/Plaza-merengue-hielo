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
    
    public partial class View_reporte_inventario
    {
        public int Producto_Id { get; set; }
        public Nullable<double> entradas { get; set; }
        public Nullable<double> salidas { get; set; }
        public string Nombre { get; set; }
        public string Descripcion_Producto { get; set; }
        public Nullable<double> precio_neto { get; set; }
        public Nullable<double> precio_salida { get; set; }
        public Nullable<bool> estatus { get; set; }
    }
}