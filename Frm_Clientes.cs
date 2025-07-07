using CapaDatos;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestiónClientesyFacturación
{
    public partial class Frm_Clientes: Form
    {
        N_Clientes objeCN = new N_Clientes();
        private string IDCliente=null;
        private bool Editar=false;  

        public Frm_Clientes()
        {
            InitializeComponent();
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        public void MostrarClientes()
        {
            N_Clientes obje = new N_Clientes();
            TablaClientes.DataSource = obje.MostrarClientes();
        }
    //FUNCIONALIDAD DE BOTONES
        private void btnGuardar_Click(object sender, EventArgs e)
        {   //Se insertan datos
            if (Editar == false)
            {
                try
                {
                    objeCN.InsertarClientes(txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDescuento.Text);
                    MessageBox.Show("Cliente agregado correctamente");
                    MostrarClientes();
                    LimpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo agregar por: " + ex);
                }
            }//Se editan los datos
            if (Editar == true)
            {
                try
                {
                    objeCN.EditarClientes(txtNombre.Text, txtTelefono.Text, txtEmail.Text, txtDescuento.Text, IDCliente);
                    MessageBox.Show("Cliente edito correctamente");
                    MostrarClientes();
                    LimpiarForm();
                    Editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " + ex);
                }
            }

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (TablaClientes.SelectedRows.Count > 0)
            {
                Editar = true;

                txtNombre.Text = TablaClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = TablaClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = TablaClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtDescuento.Text = TablaClientes.CurrentRow.Cells["Descuento"].Value.ToString();

                IDCliente = TablaClientes.CurrentRow.Cells["IDCliente"].Value.ToString();

                txtNombre.ForeColor = Color.Black;
                txtTelefono.ForeColor = Color.Black;
                txtEmail.ForeColor = Color.Black;
                txtDescuento.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Seleccione una fila para editar.");
            }
        }

        private void LimpiarForm()
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (TablaClientes.SelectedRows.Count > 0)
            {
                IDCliente = TablaClientes.CurrentRow.Cells["IDCliente"].Value.ToString();
                objeCN.EliminarClientes(IDCliente);
                MessageBox.Show("Eliminado Correctamente");
                MostrarClientes();
            }
            else
            {
                MessageBox.Show("selecione una fila para editar.");

            }

        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            N_Clientes cliente = new N_Clientes();
            TablaClientes.DataSource = cliente.BuscarClientes(txtBuscar.Text);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            form.Show();
            this.Hide();

        }
   //PARA LOS TXT DE ENTRADA DE DATOS
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

        public DataGridView misClientes { get { return TablaClientes; } }
    }
}

