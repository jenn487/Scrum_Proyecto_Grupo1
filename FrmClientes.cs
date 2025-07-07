using System;
using System.Drawing;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapNegocio;

namespace GestiónClientesyFacturación
{
    public partial class FrmClientes : Form
    {
        private readonly Ne_Clientes objNegocio = new Ne_Clientes();
        private En_Clientes clienteActual = null;
        private bool esEdicion;

        public FrmClientes()
        {
            InitializeComponent();
            esEdicion = false;
            this.Text = "Nuevo Cliente";
        }

        public FrmClientes(En_Clientes cliente) : this()
        {
            esEdicion = true;
            clienteActual = cliente;
            this.Text = "Editar Cliente";
            CargarCliente(clienteActual);
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarClientes("");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                En_Clientes cliente = new En_Clientes
                {
                    Nombre = txtNombre.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Descuento = double.TryParse(txtDescuento.Text, out double desc) ? desc : 0,
                    VecesqueCompro = esEdicion ? clienteActual.VecesqueCompro : 1
                };

                if (esEdicion)
                {
                    objNegocio.EditandoCliente(cliente);
                    MessageBox.Show("Cliente actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    objNegocio.InsertandoCliente(cliente);
                    MessageBox.Show("Cliente agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarClientes("");
                LimpiarCampos();

                // Resetear estado despue de guardar o actualizar
                esEdicion = false;
                clienteActual = null;
                btnGuardar.Text = "GUARDAR";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaClientes.CurrentRow != null)
            {
                var fila = TablaClientes.CurrentRow;
                var nombre = fila.Cells["Nombre"].Value?.ToString();
                if (nombre == null)
                {
                    MessageBox.Show("No se pudo identificar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show($"¿Seguro que desea eliminar al cliente '{nombre}'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    En_Clientes cliente = new En_Clientes
                    {
                        Nombre = nombre,
                        Telefono = fila.Cells["Telefono"].Value?.ToString(),
                        Email = fila.Cells["Email"].Value?.ToString(),
                        Descuento = Convert.ToDouble(fila.Cells["Descuento"].Value),
                        VecesqueCompro = Convert.ToInt32(fila.Cells["VecesqueCompro"].Value)
                    };

                    objNegocio.EliminandoCliente(cliente);
                    MessageBox.Show("Cliente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes("");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LimpiarCampos()
        {
        
            txtNombre.Text = "Nombre y Apellido";
            txtNombre.ForeColor = Color.Silver;

            txtTelefono.Text = "Telefono";
            txtTelefono.ForeColor = Color.Silver;

            txtEmail.Text = "Correo";
            txtEmail.ForeColor = Color.Silver;

            txtDescuento.Text = "Descuento";
            txtDescuento.ForeColor = Color.Silver;

            txtNombre.Focus();
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(txtBuscar.Text);
        }

        private void CargarClientes(string filtro)
        {
            TablaClientes.DataSource = objNegocio.ListarClientes(filtro);
            if (TablaClientes.Columns.Contains("IDCliente")) TablaClientes.Columns["IDCliente"].Visible = false;
        }

        private void CargarCliente(En_Clientes cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtTelefono.Text = cliente.Telefono;
            txtEmail.Text = cliente.Email;
            txtDescuento.Text = cliente.Descuento.ToString("F2");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDescuento.Clear();
            txtNombre.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            form.Show();
            this.Hide();
        }

        //PARA EL FORMULARIO ENTRADA DE DATOS
        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre y Apellido")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre y Apellido";
                txtNombre.ForeColor = Color.Silver;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono";
                txtTelefono.ForeColor = Color.Silver;

            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Correo")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Correo";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtDescuento_Enter(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "Descuento")
            {
                txtDescuento.Text = "";
                txtDescuento.ForeColor = Color.Black;
            }
        }

        private void txtDescuento_Leave(object sender, EventArgs e)
        {
            if (txtDescuento.Text == "")
            {
                txtDescuento.Text = "Descuento";
                txtDescuento.ForeColor = Color.Black;
            }
        }

        private void TablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = TablaClientes.Rows[e.RowIndex];
                clienteActual = new En_Clientes
                {
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Telefono = fila.Cells["Telefono"].Value.ToString(),
                    Email = fila.Cells["Email"].Value.ToString(),
                    Descuento = Convert.ToDouble(fila.Cells["Descuento"].Value),
                    VecesqueCompro = Convert.ToInt32(fila.Cells["VecesqueCompro"].Value)
                };

                txtNombre.Text = clienteActual.Nombre;
                txtTelefono.Text = clienteActual.Telefono;
                txtEmail.Text = clienteActual.Email;
                txtDescuento.Text = clienteActual.Descuento.ToString();

                esEdicion = true;
                btnGuardar.Text = "ACTUALIZAR";
            }


        }
    }
}


    

