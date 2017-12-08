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
    
    public partial class PostGrado
    {
        public int PostgradoId { get; set; }
        public string Nombre { get; set; }
        public int InstitucionId { get; set; }
        public string OtraInstitucion { get; set; }
        public Nullable<int> ProfesionId { get; set; }
        public string OtraProfesion { get; set; }
        public int TrabajadorId { get; set; }
        public string Estado { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int CategoriaId { get; set; }
        public string NombreArchivo { get; set; }
        public string RutaArchivo { get; set; }
        public Nullable<int> SubCategoriaId { get; set; }
        public Nullable<int> CursoId { get; set; }
        public Nullable<int> DiplomadoId { get; set; }
        public Nullable<int> GradoId { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        public virtual Curso Curso { get; set; }
        public virtual Diplomado Diplomado { get; set; }
        public virtual Grado Grado { get; set; }
        public virtual Institucion Institucion { get; set; }
        public virtual Profesion Profesion { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
        public virtual Trabajador Trabajador { get; set; }
    }
}
