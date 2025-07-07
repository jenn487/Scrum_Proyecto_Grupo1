
namespace CapaEntidad
{
    public class En_Clientes
    {
        private string _Nombre;
        private string _Telefono; 
        private string _Email;
        private double _Descuento;
        private int _VecesqueCompro;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public double Descuento { get => _Descuento; set => _Descuento = value; }
        public int VecesqueCompro { get => _VecesqueCompro; set => _VecesqueCompro = value; }

    }
}
