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
    
    public partial class detalles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public detalles()
        {
            this.consulta = new HashSet<consulta>();
        }
    
        public int id_detalles { get; set; }
        public Nullable<System.DateTime> fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_consulta { get; set; }
        public string usuario_creacion { get; set; }
        public Nullable<int> id_categoria { get; set; }
        public Nullable<int> id_respuesta { get; set; }
    
        public virtual categoria categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<consulta> consulta { get; set; }
        public virtual respuesta respuesta { get; set; }
    }
}
