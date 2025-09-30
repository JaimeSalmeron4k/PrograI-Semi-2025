using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comando para trabajar con Bases de Datos
using System.Data.SqlClient; //Esta Libreira me permite trabaja con SQL Server

namespace PrimerProyectoCsharp
{
    internal class Conexion
    {
        //Definir los miembros de la clase, atributos y metodos.
        SqlConnection objConexion = new SqlConnection(); //Conectarme a la BD.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL en la BD. Lectura, Actualizacion, Eliminacion, Insercion.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //un puente entre la BD y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de la BD en memoria.

        public Conexion()
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
       
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM docentes";
            objAdaptador.Fill(objDs, "docentes");//Tomando los datos de la BD y llenando el DataSet

            return objDs;
        }
        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES ('"+ datos[1] +"', '"+ datos[2] +"', '"+ datos[3] +"', '"+ datos[4] +"')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE idAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }
        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO docentes(codigo,nombre,dui,especialidad,correo,telefono,direccion) VALUES ('"+ datos[1] +"', '"+ datos[2] +"', '"+ datos[3] +"', '"+ datos[4] + "','"+ datos[5] +"', '"+ datos[6] +"', '"+ datos[7] +"')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', dui ='" + datos[3] + "', especialidad='" + datos [4] + "', correo='" + datos [5] + "', telefono ='" + datos [6] + "', direccion='" + datos [7] + "'  WHERE idDocente='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente='" + datos[0] + "'";
            }
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                objComando.Parameters.Clear();
                objComando.Parameters.AddWithValue("@idAlumno", datos[0]);
                objComando.Parameters.AddWithValue("@codigo", datos[1]);
                objComando.Parameters.AddWithValue("@nombre", datos[2]);
                objComando.Parameters.AddWithValue("@direccion", datos[3]);
                objComando.Parameters.AddWithValue("@telefono", datos[4]);

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}
    
                