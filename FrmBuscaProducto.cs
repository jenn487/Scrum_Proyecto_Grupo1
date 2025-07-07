using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónClientesyFacturación
{
    public partial class FrmBuscaProducto: Form
    {
        public FrmBuscaProducto()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtBuscar_Enter(object sender, EventArgs e)
        {
        
            if (txtBuscar.Text == "Buscar . . .")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar . . .";
                txtBuscar.ForeColor = Color.Silver;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Clientes form = new Frm_Clientes();
            form.Show();
            this.Hide();

        }

        private void FrmBuscaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}

