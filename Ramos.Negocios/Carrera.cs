using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Carrera
    {
        private string _idCarrera;
        private int _idSede;
        private string _nombreCarrera;

        public string NombreCarrera
        {
            get { return _nombreCarrera; }
            set { _nombreCarrera = value; }
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

        public Carrera()
        {
            _idCarrera = string.Empty;
            _idSede = 0;
            _nombreCarrera = string.Empty;
        }
        public Carrera(string Id_Carrera, int Id_Sede, string Nombre_Carrera)
        {
            this.IdCarrera = Id_Carrera;
            this.IdSede = Id_Sede;
            this.NombreCarrera = Nombre_Carrera;
        }
    }
}
