using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace GestiónClientesyFacturación
{
    public partial class Dashborad : Form
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader dr;
        public Dashborad()
        {
            InitializeComponent();
        }

        private void Dashborad_Load(object sender, EventArgs e)
        {
            // Mostrar nombre del usuario
            lblNombreUsuario.Text = $"{FrmLogin.nombre} ({FrmLogin.usuario_nombre})";
            // Acceso según área
            switch (FrmLogin.area)
            {
                case "A001": // Administrador
                    btnCliente.Enabled = true;
                    btnfacturas.Enabled = true;
                    btnReportes.Enabled = true;
                    lblPuesto.Text = "Administrador";
                    break;

                case "A002": // Contador
                    btnfacturas.Enabled = true;
                    btnReportes.Enabled = true;
                    lblPuesto.Text = "Contador";
                    break;

                case "A003": // Vendedor
                    btnCliente.Enabled = true;
                    btnfacturas.Enabled = true;
                    lblPuesto.Text = "Vendedor";
                    break;

                default:
                    lblPuesto.Text = "Sin rol asignado";
                    break;
            }
        }
        public void productoPreferido()
        {
            cmd = new SqlCommand("", conexion);
        }

        /*
        private void mostrarTotalVentas()
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT ISNULL(SUM(Subtotal), 0) FROM DetalleFactura WHERE MONTH(Fecha) = @Mes AND YEAR(Fecha) = @Anio", conexion);
                int totalVentas = (int)comando.ExecuteScalar();
                lblTVentas.Text = totalVentas.ToString();
            }

        }*/


        private void timer_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToLongDateString();
        }

        private void btncerrarsecion_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Frm_Clientes form = new Frm_Clientes();
            form.Show();
            this.Hide();

        }

        private void btnfacturas_Click(object sender, EventArgs e)
        {
            FrmFacturacion form = new FrmFacturacion();
            form.Show();
            this.Hide();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes form = new FrmReportes();
            form.Show();
            this.Hide();

        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

        }
    }
}
