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
    
    public partial class seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seccion()
        {
            this.inscripcion = new HashSet<inscripcion>();
        }
    
        public string id_seccion { get; set; }
        public string id_ramo { get; set; }
        public string id_carrera { get; set; }
        public int id_sede { get; set; }
        public string id_jor { get; set; }
        public string username_prof { get; set; }
        public int cupo { get; set; }
        public string dia1 { get; set; }
        public string hora_entrada1 { get; set; }
        public string hora_salida1 { get; set; }
        public string dia2 { get; set; }
        public string hora_entrada2 { get; set; }
        public string hora_salida2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<inscripcion> inscripcion { get; set; }
        public virtual jornada jornada { get; set; }
        public virtual profesor profesor { get; set; }
        public virtual ramo ramo { get; set; }
    }
}
