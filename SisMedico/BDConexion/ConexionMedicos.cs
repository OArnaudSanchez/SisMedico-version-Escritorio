using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SisMedico
{
    public class ConexionMedicos
    {
        public int IDMedico { get; set; }
        public string Nombre { get; set; }
        public string Exequatur { get; set; }
        public string Especialidad { get; set; }

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarMedico(string nombre, string exequatur, string especialidad)
        {
            conexion.Open();
            query = $"Insert into Medicos(nombre,exequatur,especialidad) Values" +
                $"('{nombre}','{exequatur}','{especialidad}')";
            comando = new SqlCommand(query,conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarMedico(int id,string nombre, string exequatur, string especialidad)
        {
            conexion.Open();
            query = $"Update Medicos set nombre='{nombre}',exequatur='{exequatur}',especialidad='{especialidad}'" +
                $"where idMedico='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarMedico(int id)
        {
            conexion.Open();
            query = $"Delete from Medicos Where idMedico='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable MostrarMedicos()
        {
            conexion.Open();
            query = "Select * from Medicos";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarMedicoNombre(string nombre)
        {
            conexion.Open();
            query = $"Select * from Medicos where nombre like '{nombre}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarMedicoEspecialidad(string especialidad)
        {
            conexion.Open();
            query = $"Select * from Medicos where especialidad like '{especialidad}%'";
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
