using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SisMedico
{
    public enum PrecioHabitacion
    {
        Doble = 2000, Privada = 4000, Suite = 6000
    }

    public class ConexionHabitaciones
    {
        public int IDHabitacion { get; set; }
        public int Numero{ get; set; }
        public string Tipo { get; set; }
        public int PrecioPorDia { get; set; }

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarHabitacion(int numero,string tipo,int precio)
        {
            conexion.Open();
            query = $"Insert into Habitaciones(numero,tipo,precioDia) Values" +
                $"('{numero}','{tipo}','{precio}')";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarHabitacion(int id,int numero, string tipo, int precio)
        {
            conexion.Open();
            query = $"Update Habitaciones set numero='{numero}',tipo='{tipo}',precioDia='{precio}'" +
                $"where idHabitacion ='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarHabitacion(int id)
        {
            conexion.Open();
            query = $"Delete from Habitaciones Where idHabitacion='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable MostrarHabitaciones()
        {
            conexion.Open();
            query = "Select * from Habitaciones";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }
        public DataTable BuscarHabitacionesTipo(string tipo)
        {
            conexion.Open();
            query = $"Select * from Habitaciones where tipo like '{tipo}%'";
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
