using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestiónClientesyFacturación
{
    public partial class FrmFacturas: Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            lblNombreyUsuario.Text = $"{FrmLogin.nombre} ({FrmLogin.usuario_nombre})";

            switch (FrmLogin.area)
            {
                case "A001": // Administrador
                    lblVendedor.Text = "Administrador";
                    break;

                case "A002": // Contador
                    lblVendedor.Text = "Contador";
                    break;

                case "A003": // Vendedor
                    lblVendedor.Text = "Vendedor";
                    break;

                default:
                    lblVendedor.Text = "Sin rol asignado";
                    break;
            }


        }
        // Varianles para la parte de la calculadora
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtScreen.TextLength == 1) txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.TextLength - 1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0") txtScreen.Text = "";
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);

            switch (operador)
            {
                case "+":
                    txtScreen.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtScreen.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtScreen.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtScreen.Text = $"{num1 / num2}";
                    break;

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            form.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmBuscaProducto form = new FrmBuscaProducto();
            form.Show();
            this.Hide();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalPagar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontoOtroPago_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDevuelta_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btbBorrarLineaDataGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnCambioUsuario_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();

        }

        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            FrmClientes form = new FrmClientes();
            form.Show();
            this.Hide();

        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {

        }
    }
}
