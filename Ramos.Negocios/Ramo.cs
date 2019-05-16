using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Ramo
    {
        #region Campos
        private string _idRamo;
        private string _idCarrera;
        private int _idSede;
        private string _nombreRamo;
        private int _semestre;

        public int Semestre
        {
            get { return _semestre; }
            set { _semestre = value; }
        }

        #endregion
        #region Atributos
        public string NombreRamo
        {
            get { return _nombreRamo; }
            set { _nombreRamo = value; }
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
        #endregion
        #region Constructores
        public Ramo()
        {
            _idRamo = string.Empty;
            _idCarrera = string.Empty;
            _idSede = 0;
            _nombreRamo = string.Empty;
        }
        public Ramo(string Id_Ramo, 
                    string Id_Carrera,
                    int    Id_Sede, 
                    string Nombre_Ramo,
                    int    Semestre)
        {
            this.IdRamo = Id_Ramo;
            this.IdCarrera = Id_Carrera;
            this.IdSede = Id_Sede;
            this.NombreRamo = Nombre_Ramo;
            this.Semestre = Semestre;
        }
        #endregion

    }
}
