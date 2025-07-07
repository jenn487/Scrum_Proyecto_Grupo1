using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System;
using CapaDatos;
using System.Security.AccessControl;


namespace CapaNegocio
{
    public class N_Clientes
    {
        public D_Clientes objetoCD = new D_Clientes();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarClientes (string nombre, string telefono, string email, string descuento)
        {
            objetoCD.Insertar(nombre, telefono, email, Convert.ToDouble(descuento));

        }
        public void EditarClientes(string nombre, string telefono, string email, string descuento, string id)
        {
            objetoCD.Editar(nombre, telefono, email, Convert.ToDouble(descuento), Convert.ToString(id));

        }
        public void EliminarClientes(string id)
        { 
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public DataTable BuscarClientes(string valor)
        {
            return objetoCD.Buscar(valor); 
        }

    }
}
