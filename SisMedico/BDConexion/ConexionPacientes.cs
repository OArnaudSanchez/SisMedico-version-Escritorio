using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SisMedico
{
    public class ConexionPacientes
    {
        public int IDPaciente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Asegurado { get; set; }

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarPaciente(string cedula, string nombre, string asegurado)
        {
            conexion.Open();
            query = $"Insert into Pacientes(cedula,nombre,asegurado) Values" +
                $"('{cedula}','{nombre}','{asegurado}')";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarPaciente(int id,string cedula, string nombre, string asegurado)
        {
            conexion.Open();
            query = $"Update Pacientes set cedula='{cedula}',nombre='{nombre}',asegurado='{asegurado}'" +
                $"where idPaciente ='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarPaciente(int id)
        {
            conexion.Open();
            query = $"Delete from Pacientes Where idPaciente='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable MostrarPacientes()
        {
            conexion.Open();
            query = "Select * from Pacientes";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }
        public DataTable BuscarPacientesNombre(string nombre)
        {
            conexion.Open();
            query = $"Select * from Pacientes where nombre like '{nombre}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarPacientesCedula(string cedula)
        {
            conexion.Open();
            query = $"Select * from Pacientes where cedula like '{cedula}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarPacientesAsegurado(string es)
        {
            conexion.Open();
            query = $"Select * from Pacientes where asegurado like '{es}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarPacientesNoAsegurado(string no)
        {
            conexion.Open();
            query = $"Select * from Pacientes where asegurado like '{no}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }
    }
}
