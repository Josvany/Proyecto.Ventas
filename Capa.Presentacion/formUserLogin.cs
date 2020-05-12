using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Capa.Presentacion
{
    public partial class formUserLogin : Form
    {
        UtilsRespository _utilRespo = new UtilsRespository();
        Encriptacion _encriptacion = new Encriptacion();
        public formUserLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formUserLogin_Load(object sender, EventArgs e)
        {
            Conexion.IniciarSesion();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Equals("Usuario"))
            {
                textUser.Text = string.Empty;
                textUser.Focus();
                textPasword.Text = string.Empty;
                return;
            }

            DataTable dtAllUser = _utilRespo.GetData("SP_GET_USER");

            var isExist = dtAllUser.AsEnumerable().Where(x => x["Usuario"].ToString() == textUser.Text && x["Contraseña"].ToString() == _encriptacion.Encriptar(textPasword.Text)).Select(x => x).FirstOrDefault();

            if (isExist != null)
            {
                Program.UserIntId = Guid.Parse(isExist["USE_INT_ID"].ToString());

                MasterContain masterContain = new MasterContain();
                masterContain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUser_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Equals("Usuario"))
            {
                textUser.Text = string.Empty;
            }
        }

        private void textPasword_Click(object sender, EventArgs e)
        {
            textPasword.Text = string.Empty;
            textPasword.isPassword = true;
        }

        private void textPasword_OnValueChanged(object sender, EventArgs e)
        {
            textPasword.ForeColor = Color.White;
            textPasword.isPassword = true;
        }

        private void textPasword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (textPasword.Text == "Contraseña")
                {
                    textPasword.Focus();
                    return;
                }

                buttonlogin_Click(null, null);
            }
        }
    }
}