using System.Collections.Generic;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad; 

namespace CapaDatos
{
    public class Dt_Clientes
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<En_Clientes> ListarClientes(string buscar)
        {
            List<En_Clientes> Listar = new List<En_Clientes>();
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_BuscarCliente", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", buscar ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Telefono", DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                cmd.Parameters.AddWithValue("@Descuento", 0);
                cmd.Parameters.AddWithValue("@Vecesquecompro", DBNull.Value);

                conexion.Open();
                using (SqlDataReader LeerFilas = cmd.ExecuteReader())
                {
                    while (LeerFilas.Read())
                    {
                        Listar.Add(new En_Clientes()
                        {
                            Nombre = LeerFilas["Nombre"].ToString(),
                            Telefono = LeerFilas["Telefono"].ToString(),
                            Email = LeerFilas["Email"].ToString(),
                            Descuento = LeerFilas["Descuento"] != DBNull.Value ? Convert.ToDouble(LeerFilas["Descuento"]) : 0.0,
                            VecesqueCompro = LeerFilas["VecesqueCompro"] != DBNull.Value ? Convert.ToInt32(LeerFilas["VecesqueCompro"]) : 0
                        });
                    }
                }
            }
            return Listar;
        }

        public void InsertarCliente(En_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("sp_InsertarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
            cmd.Parameters.AddWithValue("@Email", Cliente.Email);
            cmd.Parameters.AddWithValue("@Descuento", Cliente.Descuento);
            cmd.Parameters.AddWithValue("@VecesqueCompro", Cliente.VecesqueCompro);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCliente(En_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("sp_ActualizarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@Nombre", Cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", Cliente.Telefono);
            cmd.Parameters.AddWithValue("@Email", Cliente.Email);
            cmd.Parameters.AddWithValue("@Descuento", Cliente.Descuento);
            cmd.Parameters.AddWithValue("@VecesqueCompro", Cliente.VecesqueCompro);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCliente(En_Clientes Cliente)
        {
            SqlCommand cmd = new SqlCommand("sp_EliminarCliente", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDCliente", Cliente.Nombre);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
