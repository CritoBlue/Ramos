using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Alumno
    {
        #region Campos

        private string _alumUser;
        private string _alumPass;
        private string _alumRut;
        private string _alumNombre;
        private string _alum2doNombre;
        private string _alumApellido;
        private string _alum2doApellido;
        private long _telAlum;
        private int _semestreActual;
        private int _idSede;
        private string _idCarrera;

        #endregion
        #region Propiedades
        public string IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }


        public int IdSede
        {
            get { return _idSede; }
            set { _idSede = value; }
        }


        public int SemestreActual
        {
            get { return _semestreActual; }
            set { _semestreActual = value; }
        }


        public long TelAlumno
        {
            get { return _telAlum; }
            set { _telAlum = value; }
        }

        public string Alum2doApellido
        {
            get { return _alum2doApellido; }
            set { _alum2doApellido = value; }
        }


        public string AlumApellido
        {
            get { return _alumApellido; }
            set { _alumApellido = value; }
        }

        public string Alum2doNombre
        {
            get { return _alum2doNombre; }
            set { _alum2doNombre = value; }
        }


        public string AlumNombre
        {
            get { return _alumNombre; }
            set { _alumNombre = value; }
        }


        public string AlumRut
        {
            get { return _alumRut; }
            set { _alumRut = value; }
        }


        public string AlumContrasena
        {
            get { return _alumPass; }
            set { _alumPass = value; }
        }


        public string AlumUsername
        {
            get { return _alumUser; }
            set { _alumUser = value; }
        }
        #endregion
        #region Constructores
        public Alumno()
        {
            _alumUser = string.Empty;
            _alumPass = string.Empty;
            _alumRut = string.Empty;
            _alumNombre = string.Empty;
            _alum2doNombre = string.Empty;
            _alumApellido = string.Empty;
            _alum2doApellido = string.Empty;
            _telAlum = 0;
            _semestreActual = 0;
            _idSede = 0;
            _idCarrera = string.Empty;
        }

        public Alumno(  string Alum_Usuario,
                        string Alum_Contrasena,
                        string Alum_Rut,
                        string Alum_Nombre,
                        string Alum_2doNombre,
                        string Alum_Apellido,
                        string Alum_2doApellido,
                        long   Tel_Alum,
                        int    Semestre_Actual,
                        int    Id_Sede,
                        string Id_Carrera)
        {
            this.AlumUsername = Alum_Usuario;
            this.AlumContrasena = Alum_Contrasena;
            this.AlumRut = Alum_Rut;
            this.AlumNombre = Alum_Rut;
            this.Alum2doNombre = Alum_2doNombre;
            this.AlumApellido = Alum_Apellido;
            this.Alum2doApellido = Alum_2doApellido;
            this.TelAlumno = Tel_Alum;
            this.SemestreActual = Semestre_Actual;
            this.IdSede = Id_Sede;
            this.IdCarrera = Id_Carrera;
        }
        #endregion
    }
}
