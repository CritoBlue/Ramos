using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Profesor
    {
        #region Campos
        private string _profUser;
        private string _profPass;
        private string _profRut;
        private string _profNombre;
        private string _prof2doNombre;
        private string _profApellido;
        private string _prof2doApellido;
        private long _telefono;


        #endregion
        #region Propiedades
        
        public long ProfTelefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Prof2doApellido
        {
            get { return _prof2doApellido; }
            set { _prof2doApellido = value; }
        }


        public string ProfApellido
        {
            get { return _profApellido; }
            set { _profApellido = value; }
        }

        public string Prof2doNombre
        {
            get { return _prof2doNombre; }
            set { _prof2doNombre = value; }
        }


        public string ProfNombre
        {
            get { return _profNombre; }
            set { _profNombre = value; }
        }


        public string ProfRut
        {
            get { return _profRut; }
            set { _profRut = value; }
        }


        public string ProfContrasena
        {
            get { return _profPass; }
            set { _profPass = value; }
        }


        public string ProfUsername
        {
            get { return _profUser; }
            set { _profUser = value; }
        }
        #endregion
        #region Constructores
        public Profesor()
        {
            _profUser = string.Empty;
            _profPass = string.Empty;
            _profRut = string.Empty;
            _profNombre = string.Empty;
            _prof2doNombre = string.Empty;
            _profApellido = string.Empty;
            _prof2doApellido = string.Empty;
            _telefono = 0;
        }
        public Profesor(string Prof_Usuario,
                        string Prof_Contrasena,
                        string Prof_Rut,
                        string Prof_Nombre,
                        string Prof_2doNombre,
                        string Prof_Apellido,
                        string Prof_2doApellido,
                        long   Prof_Telefono)
        {
            this.ProfUsername = Prof_Usuario;
            this.ProfContrasena = Prof_Contrasena;
            this.ProfRut = Prof_Rut;
            this.ProfNombre = Prof_Rut;
            this.Prof2doNombre = Prof_2doNombre;
            this.ProfApellido = Prof_Apellido;
            this.Prof2doApellido = Prof2doApellido;
            this.ProfTelefono = Prof_Telefono;
        }
        #endregion
    }
}
