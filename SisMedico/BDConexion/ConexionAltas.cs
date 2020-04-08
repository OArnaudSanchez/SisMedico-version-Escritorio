using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SisMedico
{
    class ConexionAltas
    {

        public int IDAlta { get; set; }
        public int IDIngreso { get; set; }
        public DateTime fechaSalida { get; set; }
        public int Monto { get; set; }



        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=SistemaControlMedico;Integrated Security=True");
        SqlCommand comando;
        string query = "";
        public void IngresarAlta(int ingreso, DateTime fecha,int monto)
        {
            conexion.Open();
            query = $"Insert into Altas(ingreso,fechaSalida,monto) Values" +
                $"('{ingreso}','{fecha}','{monto}')";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModificarAlta(int id,int ingreso, DateTime fecha, int monto)
        {
            conexion.Open();
            query = $"Update Altas set ingreso='{ingreso}',fechaSalida='{fecha}',monto='{monto}'" +
                $"where idAlta='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EliminarAlta(int id)
        {
            conexion.Open();
            query = $"Delete from Altas Where idAlta='{id}'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable MostrarAltas()
        {
            conexion.Open();
            query = "Exec MostrarAltas";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarAltasFecha(string fecha)
        {
            conexion.Open();
            query = $"Select a.idAlta as 'ID Alta',i.idIngreso as 'ID Ingreso',p.cedula as 'Cedula Paciente', p.nombre as 'Paciente',m.nombre as 'Medico',h.tipo as 'Tipo Habitacion',h.precioDia as 'Precio Por Dia', i.fechaIngreso as 'Fecha de Ingreso', a.fechaSalida as 'Fecha de Salida', a.monto as 'Monto' from Altas a inner join Ingresos i on a.ingreso = i.idIngreso inner Join Pacientes p on i.paciente = p.idPaciente inner join Medicos m on i.medico = m.idMedico inner join Habitaciones h on i.habitacion = h.idHabitacion where cast(i.fechaIngreso as Date) like '%{fecha}%' OR cast(a.fechaSalida as Date) like '%{fecha}%'";
            comando = new SqlCommand(query, conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter datos = new SqlDataAdapter(comando);
            DataTable data = new DataTable();

            datos.Fill(data);
            conexion.Close();

            return data;
        }

        public DataTable BuscarAltasPacientes(string nombre)
        {
            conexion.Open();
            query = $"Select a.idAlta as 'ID Alta',i.idIngreso as 'ID Ingreso',p.cedula as 'Cedula Paciente', p.nombre as 'Paciente',m.nombre as 'Medico',h.tipo as 'Tipo Habitacion',h.precioDia as 'Precio Por Dia', i.fechaIngreso as 'Fecha de Ingreso', a.fechaSalida as 'Fecha de Salida', a.monto as 'Monto' from Altas a inner join Ingresos i on a.ingreso = i.idIngreso inner Join Pacientes p on i.paciente = p.idPaciente inner join Medicos m on i.medico = m.idMedico inner join Habitaciones h on i.habitacion = h.idHabitacion where p.nombre like '{nombre}%'";
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
