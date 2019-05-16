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

        public List<Inscripcion> ListarInscripcion()
        {
            List<Inscripcion> ListaInscripcion = new List<Inscripcion>();
            foreach (Datos.inscripcion ins in Conexion.Ramos.inscripcion)
            {
                Inscripcion nuevaInscripcion = new Inscripcion(ins.id_seccion,
                                                               ins.id_ramo,
                                                               ins.id_carrera,
                                                               ins.id_sede,
                                                               ins.username_alum,
                                                               ins.fecha_inscripcion);
                ListaInscripcion.Add(nuevaInscripcion);
            }
            return ListaInscripcion;
        }

        public bool Login(String user, String pass)
        {
            SqlConnection con = this.ConexionDBQuery();
            try
            {
                con.Open();
                String query = "SELECT USERNAME_ALUM, PASSWORD_ALUM FROM ALUMNO WHERE USERNAME_ALUM = '"
                    + user + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if ((dr[0]).ToString() == user)
                    {
                        if ((dr[1]).ToString() == pass)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception zz)
            {
                throw zz;
            }
            return true;
        }

        public DataTable Datitos(String username)
        {
            DataTable dt = new DataTable();
            SqlConnection sql = this.ConexionDBQuery();
            try
            {
                sql.Open();
                String query = "SELECT A.ID_SEDE, S.NOMBRE_SEDE, A.ID_CARRERA, C.NOMBRE_CARRERA, A.RUT_ALUM, A.SEMESTRE_ACTUAL,"
                + " A.PNOMBRE_ALUM + ' ' + A.SNOMBRE_ALUM + ' ' + A.PAPELLIDO_ALUM + ' ' + A.SAPELLIDO_ALUM NOMBRE " +
                "FROM ALUMNO A JOIN SEDE S ON A.id_sede = S.id_sede JOIN CARRERA C ON A.id_carrera = C.id_carrera " +
                "WHERE A.username_alum = @username " +
                "GROUP BY A.ID_SEDE, S.NOMBRE_SEDE, A.ID_CARRERA, C.NOMBRE_CARRERA, A.rut_alum, A.PNOMBRE_ALUM, " +
                "A.SNOMBRE_ALUM, A.PAPELLIDO_ALUM, A.SAPELLIDO_ALUM, A.semestre_actual;";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@username",
                    Value = username,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20
                });
                da.Fill(dt);
            }
            catch (Exception zz)
            {
                throw zz;
            }
            finally
            {
                sql.Close();
            }
            return dt;
        }

        public DataTable TablitaRamos(String user)
        {
            DataTable dt = new DataTable();
            SqlConnection sql = this.ConexionDBQuery();
            try
            {
                sql.Open();
                String query = "SELECT R.ID_RAMO Ramo, R.NOMBRE_RAMO Nombre " +
                    "FROM RAMO R JOIN ALUMNO A ON A.id_carrera = R.id_carrera AND A.id_sede = R.id_sede " +
                    "WHERE A.username_alum = @username";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@username",
                    Value = user,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20
                });
                da.Fill(dt);
            }
            catch (Exception zz)
            {
                throw zz;
            }
            finally
            {
                sql.Close();
            }
            return dt;
        }

        public DataTable TablitaSecciones(String ramo, String carrera, String sede)
        {
            DataTable dt = new DataTable();
            SqlConnection sql = this.ConexionDBQuery();
            try
            {
                sql.Open();
                String query = "SELECT SC.ID_SECCION Seccion, " +
                    "J.desc_jor Jornada, " +
                    "P.pnombre_prof + ' ' + P.papellido_prof Profesor, " +
                    "SC.CUPO Cupo, " +
                    "CASE " +
                    "WHEN SC.DIA1 = 'Lu' THEN 'Lunes' " +
                    "WHEN SC.DIA1 = 'Ma' THEN 'Martes' " +
                    "WHEN SC.DIA1 = 'Mi' THEN 'Miércoles' " +
                    "WHEN SC.DIA1 = 'Ju' THEN 'Jueves' " +
                    "WHEN SC.DIA1 = 'Vi' THEN 'Viernes' " +
                    "WHEN SC.DIA1 = 'Sa' THEN 'Sábado' " +
                    "END + ' ' + SC.hora_entrada1 + ' - ' + SC.hora_salida1 AS 'Día 1', " +
                    "CASE " +
                    "WHEN SC.DIA2 = 'Lu' THEN 'Lunes' " +
                    "WHEN SC.DIA2 = 'Ma' THEN 'Martes' " +
                    "WHEN SC.DIA2 = 'Mi' THEN 'Miércoles' " +
                    "WHEN SC.DIA2 = 'Ju' THEN 'Jueves' " +
                    "WHEN SC.DIA2 = 'Vi' THEN 'Viernes' " +
                    "WHEN SC.DIA2 = 'Sa' THEN 'Sábado' " +
                    "END + ' ' + SC.hora_entrada2 + ' - ' + SC.hora_salida2 AS 'Día 2' " +
                    "FROM SECCION SC " +
                    "JOIN JORNADA J ON SC.id_jor = J.id_jor " +
                    "JOIN PROFESOR P ON SC.username_prof = P.username_prof " +
                    "WHERE SC.id_ramo = @ramo and SC.id_sede = @sede and SC.id_carrera = @carrera " +
                    "GROUP BY SC.id_seccion, SC.id_ramo, SC.id_carrera, SC.id_sede, J.desc_jor, " +
                    "P.pnombre_prof, P.papellido_prof, cupo, SC.DIA1, SC.hora_entrada1, SC.hora_salida1,  " +
                    "SC.DIA2, SC.hora_entrada2, SC.hora_salida2";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@ramo",
                    Value = ramo,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 3
                });
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@carrera",
                    Value = carrera,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50
                });
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@sede",
                    Value = sede,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 50
                });
                da.Fill(dt);
            }
            catch (Exception zz)
            {
                throw zz;
            }
            finally
            {
                sql.Close();
            }
            return dt;
        }

        public bool CreateInscripcion(string secc, string ramo, string carrera, int sede, string user, DateTime fecha)
        {
            SqlConnection conn = this.ConexionDBQuery();
            try
            {
                conn.Open();

                string query = "INSERT INTO INSCRIPCION VALUES (@seccion, @ramo, @carrera, @sede, @username, @fecha)";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@seccion", secc);
                sql.Parameters.AddWithValue("@ramo", ramo);
                sql.Parameters.AddWithValue("@carrera", carrera);
                sql.Parameters.AddWithValue("@sede", sede);
                sql.Parameters.AddWithValue("@username", user);
                sql.Parameters.AddWithValue("@fecha", fecha);
                sql.ExecuteNonQuery();
                return true;
            }
            catch (Exception zz)
            {
                return false;
                throw zz;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable TablitaInscripcion(String user)
        {
            DataTable dt = new DataTable();
            SqlConnection sql = this.ConexionDBQuery();
            try
            {
                sql.Open();
                String query = "SELECT i.id_ramo + ' - '  + i.id_seccion as Seccion, " +
                        "r.nombre_ramo as Ramo, " +
                        "j.desc_jor as Jornada, " +
                        "CASE " +
                        "WHEN s.dia1 = 'Lu' THEN 'Lunes' " +
                        "WHEN s.dia1 = 'Ma' THEN 'Martes' " +
                        "WHEN s.dia1 = 'Mi' THEN 'Miércoles' " +
                        "WHEN s.dia1 = 'Ju' THEN 'Jueves' " +
                        "WHEN s.dia1 = 'Vi' THEN 'Viernes' " +
                        "WHEN s.dia1 = 'Sa' THEN 'Sábado' " +
                        "END + ' ' + s.hora_entrada1 + ' - ' + s.hora_salida1 AS 'Día 1', " +
                        "CASE " +
                        "WHEN s.dia2 = 'Lu' THEN 'Lunes' " +
                        "WHEN s.dia2 = 'Ma' THEN 'Martes' " +
                        "WHEN s.dia2 = 'Mi' THEN 'Miércoles' " +
                        "WHEN s.dia2 = 'Ju' THEN 'Jueves' " +
                        "WHEN s.dia2 = 'Vi' THEN 'Viernes' " +
                        "WHEN s.dia2 = 'Sa' THEN 'Sábado' " +
                        "END + ' ' + s.hora_entrada2 + ' - ' + s.hora_salida2 AS 'Día 2', " +
                        "i.fecha_inscripcion as 'Inscrito en' " +
                        "FROM inscripcion i " +
                        "JOIN seccion s ON s.id_seccion = i.id_seccion and s.id_ramo = i.id_ramo " +
                        "and s.id_carrera = i.id_carrera and s.id_sede = i.id_sede " +
                        "JOIN jornada j ON j.id_jor = s.id_jor " +
                        "JOIN ramo r ON r.id_ramo = i.id_ramo " +
                        "JOIN alumno a ON a.username_alum = i.username_alum " +
                        "WHERE i.username_alum = @username " +
                        "GROUP BY i.id_ramo, i.id_seccion, r.nombre_ramo, j.desc_jor, " +
                        "s.dia1, s.hora_entrada1, s.hora_salida1, " +
                        "s.dia2, s.hora_entrada2, s.hora_salida2, i.fecha_inscripcion";
                SqlDataAdapter da = new SqlDataAdapter(query, sql);
                da.SelectCommand.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@username",
                    Value = user,
                    SqlDbType = SqlDbType.NVarChar,
                    Size = 20
                });
                da.Fill(dt);
            }
            catch (Exception zz)
            {
                throw zz;
            }
            finally
            {
                sql.Close();
            }
            return dt;
        }

        public bool PruebaUWU()
        {
            SqlConnection conn = this.ConexionDBQuery();
            try
            {
                conn.Open();
                string query = "INSERT INTO dbo.inscripcion VALUES ('001', 'GAY', '101', 101, 'cr.sierpe', '2019-05-15');";
                SqlCommand sqlcom = new SqlCommand(query, conn);
                sqlcom.ExecuteNonQuery();
                return true;
            }
            catch (Exception zz)
            {
                return false;
                throw zz;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}