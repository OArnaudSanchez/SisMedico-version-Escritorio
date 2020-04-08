using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SisMedico
{
    class ConexionCitas
    {
        public int IDCita { get; set; }
        public int IDPaciente { get; set; }
        public int IDMedico { get; set; }
        public DateTime Fecha { get; set; }

        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarCita(int paciente,int medico, DateTime fecha)
        {
            conexion.Open();
            query = $"Insert into Citas(paciente,medico,fecha) Values" +
                $"('{paciente}','{medico}','{fecha}')";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarCita(int id,int paciente, int medico, DateTime fecha)
        {
            conexion.Open();
            query = $"Update Citas set paciente='{paciente}',medico='{medico}',fecha='{fecha}'" +
                $"where idCita='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarCita(int id)
        {
            conexion.Open();
            query = $"Delete from Citas Where idCita='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable MostrarCitas()
        {
            conexion.Open();
            query = "Exec MostrarCitas";
            comando = new SqlCommand(query,conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarCitasFecha(string fecha)
        {
            conexion.Open();
            query = $"select c.idCita, p.nombre as Paciente,m.nombre as Medico,c.fecha from Citas c inner join Pacientes p on c.paciente = p.idPaciente inner join Medicos m on c.medico = m.idMedico where cast(c.fecha as Date) like '%{fecha}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarCitasDoctor(string nombre)
        {
            conexion.Open();
            query = $"select c.idCita, p.nombre as Paciente,m.nombre as Medico,c.fecha from Citas c inner join Pacientes p on c.paciente = p.idPaciente inner join Medicos m on c.medico = m.idMedico where m.nombre like '{nombre}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarCitasPaciente(string nombre)
        {
            conexion.Open();
            query = $"select c.idCita, p.nombre as Paciente,m.nombre as Medico,c.fecha from Citas c inner join Pacientes p on c.paciente = p.idPaciente inner join Medicos m on c.medico = m.idMedico where p.nombre like '{nombre}%'";

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
