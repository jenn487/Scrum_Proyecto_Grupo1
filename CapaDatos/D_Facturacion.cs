using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class D_Facturacion
    {
        private D_Conexion conexion = new D_Conexion();


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Buscar producto 
        public DataTable BuscarProductos()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        // Buscar producto por código
        public DataTable BuscarProductoPorCodigo(string codigo)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_BuscarProductoPorCodigo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo", codigo);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }


        // Insertar factura
        public void InsertarFactura(string idFactura, DateTime fecha, int idCliente, string idEmpleado, decimal total)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_InsertarFactura";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFactura", idFactura);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(Convert.ToString(idCliente)));
            comando.Parameters.AddWithValue("@Id_empleado", idEmpleado);
            comando.Parameters.AddWithValue("@Total", total);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }
        // Insertar detalle de factura
        public void InsertarDetalleFactura(string idFactura, string descripcion, int cantidad, decimal precioUnitario, decimal descuento, decimal subtotal)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_InsertarDetalleFactura";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFactura", idFactura);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
            comando.Parameters.AddWithValue("@DescuentoAplicado", descuento);
            comando.Parameters.AddWithValue("@Subtotal", subtotal);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Insertar pago
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




        // Actualizar stock
        public void ActualizarStock(string codigo, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ActualizarStockProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Generar ID factura
        public string GenerarIdFactura()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_GenerarIdFactura";
            comando.CommandType = CommandType.StoredProcedure;

            var id = comando.ExecuteScalar().ToString();
            conexion.CerrarConexion();
            return id;
        }

        // Obtener detalles por factura
        public DataTable ObtenerDetallesPorFactura(string idFactura)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerDetallesPorFactura";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IDFactura", idFactura);

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        // Mostrar todas las facturas
        public DataTable MostrarFacturas()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarFacturas";
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        // Mostrar productos y Clientes
        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_MostrarClientes"; 
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }


        //ontener clientes por ID
        public DataTable ObtenerClientePorId(int idCliente)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_ObtenerClientePorId";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(Convert.ToString(idCliente)));

            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(tabla);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public decimal ObtenerDescuentoCliente(int idCliente)
        {
            decimal descuento = 0;

            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT Descuento FROM Clientes WHERE IdCliente = IDCliente";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("IdCliente", Convert.ToInt32(Convert.ToString(idCliente)));

                object result = comando.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    descuento = Convert.ToDecimal(result);
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción según sea necesario
                Console.WriteLine("Error al obtener descuento: " + ex.Message);
            }
            finally
            {
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }

            return descuento;
        }
        

    }
}
