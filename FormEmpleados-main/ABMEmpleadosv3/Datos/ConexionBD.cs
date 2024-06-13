using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ABMEmpleadosv3.Negocio;
using static ABMEmpleadosv3.Datos.ConexionBD;

namespace ABMEmpleadosv3.Datos
{
    public class ConexionBD
    {
        //private string CadenaConexion = @"Data Source=DESKTOP-Q6GKN7O\SQLEXPRESS;Initial Catalog=DB_Fashion_World;Integrated Security=True";
        private string CadenaConexion = Properties.Resources.CadenaConexion1;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public ConexionBD()
        {
            conexion = new SqlConnection(CadenaConexion);
        }

        public bool ComprobarConexion()
        {
            try
            {
                conexion.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Empleado> Get()
        {
            List<Empleado> empleado = new List<Empleado>();

            //string consulta = string.Empty;
            string consulta = "select id_empleado,nombre,apellido from Empleados";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado oEmpleado = new Empleado();
                        oEmpleado.codigo = reader.GetInt32(0);
                        oEmpleado.nombre = reader.GetString(1);
                        oEmpleado.apellido = reader.GetString(2);
                        //oEmpleado.contacto = reader.GetString(3);
                        //oEmpleado.doc = reader.GetInt32(4);
                        empleado.Add(oEmpleado);
                    }
                    reader.Close();
                    conexion.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Error en la consulta" + ex.Message);
                }

            }

                return empleado;
        }

        public void Add(string nombre, string apellido)
        {
            string consulta = "insert into Empleados(nombre, apellido) values" + "(@nombre, @apellido) ";

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();

                    conexion.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la consulta" + ex.Message);
                }

            }
        }
        public class Empleado
        {
            public int codigo { get; set; }
            public string nombre { get; set; }
            public string apellido { get; set; }
            //public string contacto { get; set; }
            //public string doc { get; set; }
        }

    }
}
