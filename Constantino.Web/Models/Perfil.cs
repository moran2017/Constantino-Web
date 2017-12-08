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
    
    public partial class Perfil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Perfil()
        {
            this.Postulacion = new HashSet<Postulacion>();
        }
    
        public int PerfilId { get; set; }
        public int EspecialidadId { get; set; }
        public string Requisitos { get; set; }
        public string NivelAcademico { get; set; }
        public string PostulaEn { get; set; }
        public string Estado { get; set; }
        public Nullable<int> UsuarioRegistroId { get; set; }
        public Nullable<System.DateTime> FechaRegistro { get; set; }
    
        public virtual Especialidad Especialidad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Postulacion> Postulacion { get; set; }
    }
}
