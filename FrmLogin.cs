using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaEntidad;
using CapaNegocio;

namespace GestiónClientesyFacturación
{
    public partial class FrmLogin: Form
    {
        En_Usuarios objeuser = new En_Usuarios();
        Ne_users objnuser = new Ne_users();
        Dashborad frm1 = new Dashborad();

        public static string nombre;
        public static string usuario_nombre;
        public static string area;


        public void p_logueo()
        {
            DataTable dt = new DataTable();
            objeuser.Usuario = TxtUsuario.Text;
            objeuser.Clave = txtClave.Text;

            dt = objnuser.N_user(objeuser);

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Bienvenido/a " + dt.Rows[0][2].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nombre = dt.Rows[0]["Nombre"].ToString();
                usuario_nombre = dt.Rows[0][2].ToString();
                area = dt.Rows[0][0].ToString();

                this.Hide(); 
                frm1.Show(); 

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente nuevamente.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Clear();
                txtClave.Clear();
                TxtUsuario.Focus();
            }
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = pictureBox1; //Esto es para que no se reciba el foco en el primer textbok y no se vea el texto que quiera que se vea
        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // this.WindowState = FormWindowState.Minimized;
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Usuario")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = Color.Black;
            }

        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                TxtUsuario.Text = "Usuario";
                TxtUsuario.ForeColor = Color.Silver;
            }

        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Contraseña")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }

        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Contraseña";
                txtClave.ForeColor = Color.Silver;
                txtClave.UseSystemPasswordChar = false;

            }

        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*Dashborad form = new Dashborad();
            form.Show();
            this.Hide();*/
            p_logueo();

        }
    }
}
