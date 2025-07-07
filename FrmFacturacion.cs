using CapaNegocio;
using CapaDatos;
using System.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestiónClientesyFacturación
{
    public partial class FrmFacturacion : Form
    {
        N_Clientes objeCN = new N_Clientes();
        private string IDCliente = null;
        private bool Editar = false;

        private ListBox lstCliente = new ListBox();
        private bool seleccionandoDesdeListBox = false;
        private string idClienteSeleccionado = "";

        public FrmFacturacion()
        {
            InitializeComponent();
        }
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                N_Facturacion negocio = new N_Facturacion();
                DataTable productos = negocio.MostrarProductos();
                ConfigurarAutoCompleteDescripcion();
                InicializarControlesBusqueda();
                InicializarControlesBusquedaProducto();
                CargarClientes();
                CargarEmpleados();
                InicializarTablaFactura();


                D_Facturacion facturacionDatos = new D_Facturacion();



                LimpiarFormulario();

                dtpFecha.Value = DateTime.Now;

                // Mostrar información del usuario logueado
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
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Calculadora
        // VARIABLES PARA LA PARTE DE LA CALCULADORA
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";

        }
        private void btnBack_Click_1(object sender, EventArgs e)
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
        private void btn0_Click_1(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";

        }

        private void btnPunto_Click_1(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ",";

        }
        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";

        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";

        }

        private void btnMultiplica_Click_1(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";

        }

        private void btnDivide_Click_1(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";

        }
        private void btnEnter_Click_1(object sender, EventArgs e)
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
        #endregion
        //AQUI EMPIEZAN LAS FUNCIONALIDADES DE LOS DEMAS B O T O N E S DEL FORMULARIO


        public string ObtenerIdClienteSeleccionado()
        {
            return idClienteSeleccionado;
        }
        private void InicializarControlesBusqueda()
        {
            // Configurar el ListBox
            lstCliente.Visible = false;
            lstCliente.Height = 100;
            // Posiciona el ListBox debajo del TextBox
            lstCliente.Location = new Point(txtCliente.Left, txtCliente.Bottom);
            lstCliente.Width = txtCliente.Width;
            this.Controls.Add(lstCliente);

            // Asociar eventos
            txtCliente.TextChanged += txtCliente_TextChanged;
            lstCliente.Click += lstCliente_Click;
            txtCliente.Leave += txtCliente_Leave;
            txtCliente.KeyDown += txtCliente_KeyDown;
        }
        private void FiltrarClientes(string textoFiltro)
        {
            try
            {
                D_Conexion conexion = new D_Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT IdCliente, Nombre FROM Clientes WHERE Nombre LIKE @filtro";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@filtro", "%" + textoFiltro + "%");

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstCliente.Visible = dt.Rows.Count > 0;
                if (dt.Rows.Count > 0)
                {
                    lstCliente.DataSource = dt;
                    lstCliente.DisplayMember = "Nombre";
                    lstCliente.ValueMember = "IDCliente";
                    // lstCliente.Items.Clear();

                }
                else
                {
                    lstCliente.DataSource = null;
                }
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lstCliente_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedIndex != -1)
            {
                seleccionandoDesdeListBox = true;

                // Obtener el DataRowView seleccionado
                DataRowView selectedRow = (DataRowView)lstCliente.SelectedItem;
                txtCliente.Text = selectedRow["Nombre"].ToString();
                idClienteSeleccionado = selectedRow["Nombre"].ToString();

                lstCliente.Visible = false;
                seleccionandoDesdeListBox = false;
            }
        }


        private void CargarClientes()
        {
            DataTable clientes = objeCN.MostrarClientes();

        }
        // Metodo
        private void CargarEmpleados()
        {
            try
            {
                D_Conexion conexion = new D_Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT Id_empleado, Nombre FROM Usuarios";
                comando.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbEmpleado.DataSource = dt;
                cmbEmpleado.DisplayMember = "Nombre";
                cmbEmpleado.ValueMember = "Id_empleado";
                cmbEmpleado.SelectedIndex = -1;

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            form.Show();
            this.Hide();

        }
        private void btnAnadirCliente_Click(object sender, EventArgs e)
        {
            Frm_Clientes form = new Frm_Clientes();
            form.Show();
            this.Hide();

        }

        private void btnCambioUsuario_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Hide();

        }


        private void CalcularTotalProducto()
        {
            if (!string.IsNullOrEmpty(lblPrecio.Text) && numCantidad.Value > 0)
            {
                decimal precio = decimal.Parse(lblPrecio.Text);
                int cantidad = (int)numCantidad.Value;
                decimal descuento = string.IsNullOrEmpty(txtDescuento.Text) ? 0 : decimal.Parse(txtDescuento.Text);

                decimal subtotal = (precio * cantidad) - descuento;
                lblTotalFactura.Text = subtotal.ToString("C");
            }
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in TablaFactura.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }

            lblTotalFactura.Text = total.ToString("C");
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {


        }
        private void lblTotalFactura_Click(object sender, EventArgs e)
        {
        }

        private void txtEfectivoDado_TextChanged(object sender, EventArgs e)
        {
        }
        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
        }

        private void InicializarTablaFactura()
        {
        }
        private void LimpiarFormulario()
        {
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void ConfigurarAutoCompleteDescripcion()
        {
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            DataTable productos = new N_Facturacion().MostrarProductos();

            foreach (DataRow row in productos.Rows)
            {
                autoComplete.Add(row["Descripcion"].ToString());
            }

            lblDescripcion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            lblDescripcion.AutoCompleteSource = AutoCompleteSource.CustomSource;
            lblDescripcion.AutoCompleteCustomSource = autoComplete;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDevueltaalCliente_Click(object sender, EventArgs e)
        {

        }

        private void TablaFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (seleccionandoDesdeListBox) return;

            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lstCliente.Visible = false;
                return;
            }

            FiltrarClientes(txtCliente.Text);
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            // pequeño retraso para permitir que se procese el clic en el ListBox
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                this.Invoke(new Action(() =>
                {
                    lstCliente.Visible = false;
                    timer.Dispose();
                }));
            }, null, 200, System.Threading.Timeout.Infinite);
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstCliente.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (lstCliente.SelectedIndex < lstCliente.Items.Count - 1)
                            lstCliente.SelectedIndex++;
                        e.Handled = true;
                        break;

                    case Keys.Up:
                        if (lstCliente.SelectedIndex > 0)
                            lstCliente.SelectedIndex--;
                        e.Handled = true;
                        break;

                    case Keys.Enter:
                        if (lstCliente.SelectedIndex != -1)
                        {
                            lstCliente_Click(lstCliente, EventArgs.Empty);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                        }
                        break;

                    case Keys.Escape:
                        lstCliente.Visible = false;
                        e.Handled = true;
                        break;
                }
            }
        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            if (lstCliente.SelectedIndex != -1)
            {
                seleccionandoDesdeListBox = true;

                // Obtener el DataRowView seleccionado
                DataRowView selectedRow = (DataRowView)lstCliente.SelectedItem;

                // Asignar el nombre al TextBox
                txtCliente.Text = selectedRow["Nombre"].ToString();
                idClienteSeleccionado = selectedRow["IDCliente"].ToString();

                lstCliente.Visible = false;
                seleccionandoDesdeListBox = false;
            }
        }


        //PARA BUSCAR PRODUCTOS

        private ListBox lstProductos = new ListBox();
        private bool desdeListBox = false;
        private string codigoProductoSeleccionado = "";
        private string nombreProductoSeleccionado = "";
        private decimal precioProductoSeleccionado = 0;

        private void InicializarControlesBusquedaProducto()
        {
            lstProductos.Visible = false;
            lstProductos.Height = 100;
            lstProductos.Location = new Point(txtProducto.Left, txtProducto.Bottom);
            lstProductos.Width = txtProducto.Width;
            this.Controls.Add(lstProductos);

            txtProducto.TextChanged += TxtProducto_TextChanged;
            lstProductos.Click += LstProductos_Click;
            txtProducto.Leave += TxtProducto_Leave;
            txtProducto.KeyDown += TxtProducto_KeyDown;
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {
            if (desdeListBox) return;

            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                lstProductos.Visible = false;
                return;
            }

            FiltrarProductos(txtProducto.Text);
        }

        private void FiltrarProductos(string textoFiltro)
        {
            try
            {
                D_Conexion conexion = new D_Conexion();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT Codigo, NombreArticulo FROM Productos WHERE NombreArticulo LIKE @filtro OR Codigo LIKE @filtro";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@filtro", "%" + textoFiltro + "%");

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstProductos.Items.Clear();
                lstProductos.DisplayMember = "NombreArticulo";
                lstProductos.ValueMember = "Codigo";
                lstProductos.DataSource = dt;

                lstProductos.Visible = dt.Rows.Count > 0;

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstProductos_Click(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
            {
                desdeListBox = true;

                // Obtener el DataRowView seleccionado
                DataRowView selectedRow = (DataRowView)lstProductos.SelectedItem;
                txtProducto.Text = selectedRow["NombreArticulo"].ToString();
                codigoProductoSeleccionado = selectedRow["Codigo"].ToString();
                nombreProductoSeleccionado = selectedRow["NombreArticulo"].ToString();

                lstProductos.Visible = false;
                desdeListBox = false;

                panel2.Focus();
            }
        }

        private void TxtProducto_Leave(object sender, EventArgs e)
        {
            System.Threading.Timer timer = null;
            timer = new System.Threading.Timer((obj) =>
            {
                this.Invoke(new Action(() =>
                {
                    lstProductos.Visible = false;
                    timer.Dispose();
                }));
            }, null, 200, System.Threading.Timeout.Infinite);
        }

        private void TxtProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstProductos.Visible)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (lstProductos.SelectedIndex < lstProductos.Items.Count - 1)
                            lstProductos.SelectedIndex++;
                        e.Handled = true;
                        break;

                    case Keys.Up:
                        if (lstProductos.SelectedIndex > 0)
                            lstProductos.SelectedIndex--;
                        e.Handled = true;
                        break;

                    case Keys.Enter:
                        if (lstProductos.SelectedIndex != -1)
                        {
                            LstProductos_Click(lstProductos, EventArgs.Empty);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                        }
                        break;

                    case Keys.Escape:
                        lstProductos.Visible = false;
                        e.Handled = true;
                        break;
                }
            }
        }

        public string ObtenerCodigoProductoSeleccionado()
        {
            return codigoProductoSeleccionado;
        }

        public string ObtenerNombreProductoSeleccionado()
        {
            return nombreProductoSeleccionado;
        }

        public decimal ObtenerPrecioProductoSeleccionado()
        {
            return precioProductoSeleccionado;
        }

        public DataTable CargarDetallesProducto()
        {
            if (string.IsNullOrEmpty(codigoProductoSeleccionado))
                return null;

            D_Facturacion facturacion = new D_Facturacion();
            return facturacion.BuscarProductoPorCodigo(codigoProductoSeleccionado);
        }
    }
}



