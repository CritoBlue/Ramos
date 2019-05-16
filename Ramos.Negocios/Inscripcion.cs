using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Inscripcion
    {
        #region Campos
        private string _idSeccion;
        private string _idRamo;
        private string _idCarrera;
        private int _idSede;
        private string _alumUsuario;
        private DateTime _fechaInscripcion;
        #endregion
        #region Propiedades
        public string AlumUsuario
        {
            get { return _alumUsuario; }
            set { _alumUsuario = value; }
        }


        public int IdSede
        {
            get { return _idSede; }
            set { _idSede = value; }
        }


        public string IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }


        public string IdRamo
        {
            get { return _idRamo; }
            set { _idRamo = value; }
        }


        public string IdSeccion
        {
            get { return _idSeccion; }
            set { _idSeccion = value; }
        }

        public DateTime FechaInscripcion
        {
            get { return _fechaInscripcion; }
            set { _fechaInscripcion = value; }
        }
        #endregion
        #region Constructores
        public Inscripcion()
        {
            _idSeccion = string.Empty;
            _idRamo = string.Empty;
            _idCarrera = string.Empty;
            _idSede = 0;
            _alumUsuario = string.Empty;
            _fechaInscripcion = DateTime.Now;
        }

        public Inscripcion(string Id_Seccion,
                             string Id_Ramo,
                             string Id_Carrera,
                             int Id_Sede,
                             string Alumno_Usuario,
                             DateTime Fecha_Inscripcion)
        {
            this.IdSeccion = Id_Seccion;
            this.IdRamo = Id_Ramo;
            this.IdCarrera = Id_Carrera;
            this.IdSede = Id_Sede;
            this.AlumUsuario = Alumno_Usuario;
            this.FechaInscripcion = Fecha_Inscripcion;
        }
        #endregion
        #region Métodos
        public bool Create()
        {
            try
            {
                Datos.inscripcion ins = new Datos.inscripcion()
                {
                    id_seccion = this.IdSeccion,
                    id_ramo = this.IdRamo,
                    id_carrera = this.IdCarrera,
                    id_sede = this.IdSede,
                    username_alum = this.AlumUsuario,
                    fecha_inscripcion = this.FechaInscripcion
                };
                Conexion.Ramos.inscripcion.Add(ins);
                Conexion.Ramos.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
