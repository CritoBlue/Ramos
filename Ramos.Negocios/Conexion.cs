using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ramos.Datos;

namespace Ramos.Negocios
{
    internal class Conexion
    {
        private static RamosEntities _ramos;
        public static RamosEntities Ramos
        {
            get
            {
                if (_ramos == null)
                {
                    _ramos = new RamosEntities();
                }
                return _ramos;
            }
            set
            {
                _ramos = value;
            }
        }
    }
}