using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SisMedico
{
    class ConexionIngresos
    {
        public int IDIngreso { get; set; }
        public int IDPaciente { get; set; }
        public int IDHabitacion { get; set; }
        public int IDMedico { get; set; }
        public DateTime FechaIngreso { get; set; }



        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarIngreso(int paciente, int habitacion, int medico,DateTime fecha)
        {
            conexion.Open();
            query = $"Insert into Ingresos(paciente,habitacion,medico,fechaIngreso) Values" +
                $"('{paciente}','{habitacion}','{medico}','{fecha}')";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarIngreso(int id,int paciente, int habitacion, int medico, DateTime fecha)
        {
            conexion.Open();
            query = $"Update Ingresos set paciente='{paciente}',habitacion='{habitacion}',medico='{medico}',fechaIngreso='{fecha}'" +
                $"where idIngreso ='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarIngreso(int id)
        {
            conexion.Open();
            query = $"Delete from Ingresos Where idIngreso='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public DataTable MostrarIngresos()
        {
            conexion.Open();
            query = "Exec MostrarIngresos";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarIngresosFecha(string fecha)
        {
            conexion.Open();
            query = $"select i.idIngreso,p.nombre as 'Paciente',h.tipo as 'Habitacion' ,h.precioDia as 'Precio Habitacion' ,m.nombre as 'Medico',i.fechaIngreso from Ingresos i inner Join Habitaciones h on i.habitacion = h.idHabitacion inner join Pacientes p on i.paciente = p.idPaciente inner join Medicos m on i.medico = m.idMedico where cast(i.fechaIngreso as Date) like '%{fecha}%'";

            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarIngresosHabitacion(string habitacion )
        {
            conexion.Open();
            query = $"select i.idIngreso as 'ID Ingreso',p.nombre as 'Paciente',h.tipo as 'Tipo De Habitacion',h.precioDia as 'Precio Por Dia' ,m.nombre as 'Medico', i.fechaIngreso as 'Fecha de Ingreso' from Ingresos i inner Join Habitaciones h on i.habitacion = h.idHabitacion inner join Pacientes p on i.paciente = p.idPaciente inner join Medicos m on i.medico = m.idMedico where h.tipo like '{habitacion}%'";
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
