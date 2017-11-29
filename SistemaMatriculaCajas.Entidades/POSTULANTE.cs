//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaMatriculaCajas.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class POSTULANTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POSTULANTE()
        {
            this.EXAMEN = new HashSet<EXAMEN>();
            this.MATRICULA = new HashSet<MATRICULA>();
        }
    
        public int Cod_Postulante { get; set; }
        public Nullable<System.DateTime> Fecha_Inscripcion { get; set; }
        public int Cod_Persona { get; set; }
        public int Cod_Salon { get; set; }
        public int Cod_CarreraP { get; set; }
        public int Cod_Periodo { get; set; }
        public int Cod_Modalidad { get; set; }
        public string Turno { get; set; }
    
        public virtual CARRERA_PROFESIONAL CARRERA_PROFESIONAL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXAMEN> EXAMEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATRICULA> MATRICULA { get; set; }
        public virtual MODALIDAD MODALIDAD { get; set; }
        public virtual PERIODO PERIODO { get; set; }
        public virtual PERSONA PERSONA { get; set; }
        public virtual SALON SALON { get; set; }
    }
}
