using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Pagos
    {
        private D_Conexion conexion = new D_Conexion();
        SqlCommand comando = new SqlCommand();

        public void InsertarPago(string idFactura, decimal montoTotal, string metodoPago, DateTime fechaPago)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_InsertarPago";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IDFactura", idFactura);
            comando.Parameters.AddWithValue("@MontoTotal", montoTotal);
            comando.Parameters.AddWithValue("@MetodoPago", metodoPago);
            comando.Parameters.AddWithValue("@FechaPago", fechaPago);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}