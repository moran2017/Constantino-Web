//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Constantino.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Distribucion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Distribucion()
        {
            this.Experiencia = new HashSet<Experiencia>();
            this.UnidadNegocio = new HashSet<UnidadNegocio>();
        }
    
        public int DistribucionId { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Experiencia> Experiencia { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnidadNegocio> UnidadNegocio { get; set; }
    }
}
