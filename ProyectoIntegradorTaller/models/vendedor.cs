//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoIntegradorTaller.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vendedor()
        {
            this.respuesta = new HashSet<respuesta>();
        }
    
        public int dni { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public string usuario_creacion { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public Nullable<int> id_departamento { get; set; }
    
        public virtual departamento departamento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuesta> respuesta { get; set; }
    }
}