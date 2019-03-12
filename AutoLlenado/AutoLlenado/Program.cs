using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AutoLlenado
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int i = 500001; i <= 3000000; i++)
                {
                    SqlConnection conexion ;                
                //conexion.Open();
                //Console.WriteLine("Conexion exitosa");
                String scrip = "INSERT INTO ALUMNOS (matricula,curp,apellido1,apellido2,nombre,fechaNacimiento,nombreEscuelaProcedencia,direccionAlumno,telefono,tipoSangre,nombreTutor,direccionTutor,telefonoTutor)"+
                    " VALUES(@matricula,@curp,@ape1,@ape2,@nombre,@fecha,@escuela,@dire,@tel,@sangre,@tutor,@dirtutor,@teltutor);";
                SqlCommand comando = null;
                Alumno alu=null;
                //Random rmd = new Random();
               
                    conexion = new SqlConnection();
                    conexion.ConnectionString = "server=.\\SQLEXPRESS;  database=investigacion; user=sa; password=Rusjjmrs";
                    conexion.Open();
                    comando = new SqlCommand(scrip, conexion);                    
                    alu = new Alumno(i);
                    comando.Parameters.AddWithValue("matricula",alu.Matricula);
                    comando.Parameters.AddWithValue("curp",alu.Curp );
                    comando.Parameters.AddWithValue("ape1", alu.Apellido1);
                    comando.Parameters.AddWithValue("ape2", alu.Apellido2);
                    comando.Parameters.AddWithValue("nombre", alu.Nombre);
                    comando.Parameters.AddWithValue("fecha", alu.FechaNacimiento);
                    comando.Parameters.AddWithValue("escuela", alu.Escuela);
                    comando.Parameters.AddWithValue("dire", alu.Direccion);
                    comando.Parameters.AddWithValue("tel", alu.Telefono);
                    comando.Parameters.AddWithValue("sangre", alu.TipoSangre);
                    comando.Parameters.AddWithValue("tutor", alu.Tutor);
                    comando.Parameters.AddWithValue("dirtutor", alu.DireccionTutor);
                    comando.Parameters.AddWithValue("teltutor", alu.Telefono);
                    //Console.WriteLine(alu.toString());
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexion.Close();

                
                Console.WriteLine(i);
                    //conexion.Close();    //se cierra la conexion para liberar espacio en memoria
                    //comando.Dispose();
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Conexion fallida: " + err);
            }


            Console.ReadKey();
        }
    }
}
