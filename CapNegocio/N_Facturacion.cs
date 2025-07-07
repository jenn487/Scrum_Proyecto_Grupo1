using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Facturacion
    {
        private D_Facturacion objDatos = new D_Facturacion();


        public void ActualizarStock(string codigo, int cantidad) => objDatos.ActualizarStock(codigo, cantidad);

        public string GenerarIdFactura() => objDatos.GenerarIdFactura();

        public void InsertarFactura(string idFactura, DateTime fecha, int idCliente, string idEmpleado, decimal total)
            => objDatos.InsertarFactura(idFactura, fecha, Convert.ToInt32(Convert.ToString(idCliente)), idEmpleado, total);

        public void InsertarDetalleFactura(string idFactura, string descripcion, int cantidad, decimal precioUnitario, decimal descuento, decimal subtotal)
            => objDatos.InsertarDetalleFactura(idFactura, descripcion, cantidad, precioUnitario, descuento, subtotal);

        public void InsertarPago(string idFactura, decimal montoTotal, string metodoPago, DateTime fechaPago)
            => objDatos.InsertarPago(idFactura, montoTotal, metodoPago, fechaPago);

        public DataTable ObtenerDetallesPorFactura(string idFactura) => objDatos.ObtenerDetallesPorFactura(idFactura);

        public DataTable MostrarFacturas() => objDatos.MostrarFacturas();

        public DataTable MostrarProductos() => objDatos.MostrarProductos();
        public DataTable ObtenerClientePorId(int idCliente)
        {
            return objDatos.ObtenerClientePorId(Convert.ToInt32(Convert.ToString(idCliente)));
        }

    }
}
