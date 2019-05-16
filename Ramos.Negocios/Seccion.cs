using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Seccion
    {
        #region Campos
        private string _idSeccion;
        private string _idRamo;
        private string _idCarrera;
        private int _idSede;
        private string _idJor;
        private string _username;
        private string _dia2;
        private string _dia1;
        private int _cupo;
        private string _horaEntrada1;
        private string _horaSalida1;
        private string _horaEntrada2;
        private string _horaSalida2;
        #endregion
        #region Propiedades

        public string HoraSalida2
        {
            get { return _horaSalida2; }
            set { _horaSalida1 = value; }
        }

        public string HoraEntrada2
        {
            get { return _horaEntrada2; }
            set { _horaEntrada1 = value; }
        }
        public string HoraSalida1
        {
            get { return _horaSalida1; }
            set { _horaSalida1 = value; }
        }

        public string HoraEntrada1
        {
            get { return _horaEntrada1; }
            set { _horaEntrada1 = value; }
        }


        public int Cupo
        {
            get { return _cupo; }
            set { _cupo = value; }
        }

        public string Dia2
        {
            get { return _dia2; }
            set { _dia2 = value; }
        }

        public string Dia1
        {
            get { return _dia1; }
            set { _dia1 = value; }
        }


        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }


        public string IdJornada
        {
            get { return _idJor; }
            set { _idJor = value; }
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
        #endregion
        #region Constructores
        public Seccion()
        {
            _idSeccion = string.Empty;
            _idRamo = string.Empty;
            _idCarrera = string.Empty;
            _idSede = 0;
            _username = string.Empty;
            _cupo = 0;
            _horaEntrada1 = string.Empty;
            _horaEntrada2 = string.Empty;
            _horaSalida1 = string.Empty;
            _horaSalida2 = string.Empty;

        }
        public Seccion(string Id_Seccion,
                       string Id_Ramo,
                       string Id_Carrera,
                       int Id_Sede,
                       string Id_Jornada,
                       string Nombre_Usuario,
                       int Cupo,
                       string Dia1,
                       string Hora_Entrada1,
                       string Hora_Salida1,
                       string Dia2,
                       string Hora_Entrada2,
                       string Hora_Salida2)
        {
            this.IdSeccion = Id_Seccion;
            this.IdRamo = Id_Ramo;
            this.IdCarrera = Id_Carrera;
            this.IdSede = Id_Sede;
            this.IdJornada = Id_Jornada;
            this.Username = Nombre_Usuario;
            this.Dia1 = Dia1;
            this.Dia2 = Dia2;
            this.Cupo = Cupo;
            this.HoraEntrada1 = Hora_Entrada1;
            this.HoraEntrada2 = Hora_Entrada2;
            this.HoraSalida1 = Hora_Salida1;
            this.HoraSalida2 = Hora_Salida2;
       
        }
        #endregion
    }
}
