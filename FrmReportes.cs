using CapaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace GestiónClientesyFacturación
{
    public partial class FrmReportes: Form
    {
        SqlConnection conectar = new SqlConnection("Server=DESKTOP-S7LGA97\\SQLEXPRESS;DataBase=GestionClientesFacturas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        ArrayList Stock = new ArrayList();
        ArrayList Cuant = new ArrayList();

        public FrmReportes()
        {
            InitializeComponent();
            mostrarTclientes();
            mostrarCantidadFacturas();
            mostrarDescuento();
            FillChart();

        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

        }
        ArrayList Productos = new ArrayList();
        private void GraftCategories()
        {
            cmd = new SqlCommand("sp_FacturacionPorCliente", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            form.Show();
            this.Hide();

        }
        private void mostrarTclientes()
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Clientes", conexion);
                int totalClientes = (int)comando.ExecuteScalar();
                lblTClientes.Text = totalClientes.ToString();
            }

        }

        private void mostrarCantidadFacturas()
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT COUNT(*) FROM Facturas WHERE MONTH(Fecha) = 4 AND YEAR(Fecha) = 2025", conexion);
                int totalFacturas = (int)comando.ExecuteScalar();
                lblFemitidas.Text = totalFacturas.ToString();
            }

        }

        public void mostrarDescuento()
        {
            using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("SELECT COUNT(*) AS TotalClientesConDescuento\r\nFROM Clientes\r\nWHERE Descuento > 0;\r\n", conexion);
                int totaldes = (int)comando.ExecuteScalar();
                lblDto.Text = totaldes.ToString();
            }

        }

        void FillChart ()
        {
            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
           DataTable dt = new DataTable();
            conexion.Open ();
            SqlDataAdapter da = new SqlDataAdapter("SELECT NombreArticulo, Stock, \r\n       CASE \r\n           WHEN Stock = 0 THEN 'Agotado'\r\n           ELSE 'Pocas unidades'\r\n       END AS Estado\r\nFROM Productos\r\nWHERE Stock < 10\r\nORDER BY Stock ASC;\r\n", conexion);

            da.Fill (dt);
            chartFacClient.DataSource = dt;
            conexion.Close ();

            chartFacClient.Series["Pocas unidades en Stock"].XValueMember = "NombreArticulo";
            chartFacClient.Series["Pocas unidades en Stock"].YValueMembers = "Stock";
            chartFacClient.Titles.Add("Pocas unidades en Stock");

        }

    }
}
