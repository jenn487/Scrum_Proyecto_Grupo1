using CapaEntidad;
using CapaDatos;
using CapNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CapNegocio
{
    public class Ne_Clientes 
    {
        Dt_Clientes objDato = new Dt_Clientes();
        public List<En_Clientes> ListarClientes(string buscar)
        {
            return objDato.ListarClientes(buscar);
        }

        public void InsertandoCliente(En_Clientes Cliente)
        {
            objDato.InsertarCliente(Cliente);
        }
        public void EditandoCliente(En_Clientes Cliente)
        {
            objDato.EditarCliente(Cliente);
        }
        public void EliminandoCliente(En_Clientes Cliente)
        {
            objDato.EliminarCliente(Cliente);
        }
        
    }
}
