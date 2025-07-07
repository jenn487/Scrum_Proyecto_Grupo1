using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CapaDatos
{
    public class D_Clientes
    { 
        private D_Conexion conexion = new D_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        //Para insertar registros de clientes
        public void Insertar(string nombre, string telefono, string email, double descuento)
        {               //PROCEDIMIENTOS
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_InsertarCliente";
            comando.CommandType= CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Descuento", descuento);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        //Para editar registros de clientes
        public void Editar(string nombre, string telefono, string email, double descuento, string id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Descuento", descuento);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        //Para eliminar registros de clientes
        public  void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDCliente", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        //Para buscar registros de clientes
        public DataTable Buscar(string valor)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand("sp_BuscarCliente", conexion.AbrirConexion());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@BuscarCliente", valor);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
