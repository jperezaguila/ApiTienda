//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorio.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.ProductosAlmacen = new HashSet<ProductosAlmacen>();
        }
    
        public int idProducto { get; set; }
        public string fabricante { get; set; }
        public int pcoste { get; set; }
        public int pventa { get; set; }
        public int etiqueta { get; set; }
        public int idCategoria { get; set; }
        public int idEtiqueta { get; set; }
    
        public virtual Almacen Almacen { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Etiqueta Etiqueta1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductosAlmacen> ProductosAlmacen { get; set; }
    }
}
