//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ramos.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public alumno()
        {
            this.inscripcion = new HashSet<inscripcion>();
        }
    
        public string username_alum { get; set; }
        public string password_alum { get; set; }
        public string rut_alum { get; set; }
        public string pnombre_alum { get; set; }
        public string snombre_alum { get; set; }
        public string papellido_alum { get; set; }
        public string sapellido_alum { get; set; }
        public long tel_alum { get; set; }
        public int semestre_actual { get; set; }
        public int id_sede { get; set; }
        public string id_carrera { get; set; }
    
        public virtual carrera carrera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inscripcion> inscripcion { get; set; }
    }
}
