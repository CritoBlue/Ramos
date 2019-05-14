using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Sede
    {
        #region Campos
        private int _idSede;
        private string _nombreSede;
        #endregion
        #region Propiedades
        public string NombreSede
        {
            get { return _nombreSede; }
            set { _nombreSede = value; }
        }


        public int IdSede
        {
            get { return _idSede; }
            set { _idSede = value; }
        }        
        #endregion
        #region Constructores
        public Sede()
        {
            _idSede = 0;
            _nombreSede = string.Empty;
        }

        public Sede(int Id_Sede,
                    string Nombre_Sede)
        {
            this.IdSede = Id_Sede;
            this.NombreSede = Nombre_Sede;
        }
        #endregion
    }
}
