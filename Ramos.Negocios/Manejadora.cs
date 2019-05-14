using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ramos.Negocios
{
    public class Manejadora
    {
        public Manejadora()
        {

        }
        public SqlConnection ConexionDBQuery()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString =
            "Data Source=CRITO-PC\\SQLSERVER;" +
            "Initial Catalog=Ramos;" +
            "integrated security = True;" +
            "MultipleActiveResultSets = True;";

            return conn;
        }

        public List<Seccion> ListarSeccion()
        {
            List<Seccion> ListaClientes = new List<Seccion>();
            foreach (Datos.seccion sec in Conexion.Ramos.seccion)
            {
                Seccion nuevaSeccion = new Seccion(sec.id_seccion,
                                                   sec.id_ramo,
                                                   sec.id_carrera,
                                                   sec.id_sede,
                                                   sec.id_jor,
                                                   sec.username_prof, 
                                                   sec.cupo,                                                  
                                                   sec.dia1,
                                                   sec.hora_entrada1,
                                                   sec.hora_salida1,
                                                   sec.dia2,
                                                   sec.hora_entrada2,
                                                   sec.hora_salida2
                                                   );
                ListaClientes.Add(nuevaSeccion);
            }  
            return ListaClientes;
        }

        public List<Alumno> ListarAlumno()
        {
            List<Alumno> ListaAlumno = new List<Alumno>();
            foreach (Datos.alumno alu in Conexion.Ramos.alumno)
            {
                Alumno nuevoAlumno = new Alumno(alu.username_alum,
                                               alu.password_alum,
                                               alu.rut_alum,
                                               alu.pnombre_alum,
                                               alu.snombre_alum,
                                               alu.password_alum,
                                               alu.sapellido_alum,
                                               alu.tel_alum,
                                               alu.semestre_actual,
                                               alu.id_sede,
                                               alu.id_carrera);
                ListaAlumno.Add(nuevoAlumno);

            }
            return ListaAlumno;
        }

        public List<Carrera> ListarCarrera()
        {
            List<Carrera> ListaCarrera = new List<Carrera>();
            foreach(Datos.carrera car in Conexion.Ramos.carrera)
            {
                Carrera nuevaCarrera = new Carrera(car.id_carrera,
                                                   car.id_sede,
                                                   car.nombre_carrera);
                ListaCarrera.Add(nuevaCarrera);
            }
            return ListaCarrera;
        }

        public List<Profesor> ListarProfe()
        {
            List<Profesor> ListaProfe = new List<Profesor>();
            foreach (Datos.profesor prof in Conexion.Ramos.profesor)
            {
                Profesor nuevoProfesor = new Profesor(prof.username_prof,
                                               prof.password_prof,
                                               prof.rut_prof,
                                               prof.pnombre_prof,
                                               prof.snombre_prof,
                                               prof.password_prof,
                                               prof.sapellido_prof,
                                               prof.tel_prof);
                ListaProfe.Add(nuevoProfesor);

            }
            return ListaProfe;
        }

        public List<Ramo> ListarRamo()
        {
            List<Ramo> ListaRamo = new List<Ramo>();
            foreach (Datos.ramo ram in Conexion.Ramos.ramo)
            {
                Ramo nuevoRamo = new Ramo(ram.id_ramo,
                                          ram.id_carrera,
                                          ram.id_sede,
                                          ram.nombre_ramo,
                                          ram.semestre);
                ListaRamo.Add(nuevoRamo);
            }
            return ListaRamo;
        }

        //public List<Inscripcion> ListarInscripcion()
        //{
        //    List<Inscripcion> ListaInscripcion = new List<Inscripcion>();
        //    foreach (Datos.inscripcion ins in Conexion.Ramos.inscripcion)
        //    {
        //        Inscripcion nuevaInscripcion = new Inscripcion(ins.id_seccion,
        //                                                       ins.id_ramo,
        //                                                       ins.id_carrera,
        //                                                       ins.id_sede,
        //                                                       ins.username_alum,
        //                                                       ins.fecha_inscripcion);
        //        ListaInscripcion.Add(nuevaInscripcion);
        //    }
        //    return ListaInscripcion;
        //}

    }
}