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
    
    public partial class inscripcion
    {
        public string id_seccion { get; set; }
        public string id_ramo { get; set; }
        public string id_carrera { get; set; }
        public int id_sede { get; set; }
        public string username_alum { get; set; }
        public System.DateTime fecha_inscripcion { get; set; }
    
        public virtual alumno alumno { get; set; }
        public virtual seccion seccion { get; set; }
    }
}