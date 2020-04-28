using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class MasterContain : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        //Constructor
        public MasterContain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel
            {
                Size = new Size(7, 40)
            };
            hideSubMenu();
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void OpenForm<IsOpenForm>() where IsOpenForm : Form, new()
        {
            Form formOpen;
            formOpen = panelDesktop.Controls.OfType<IsOpenForm>().FirstOrDefault();

            if (formOpen == null)
            {
                formOpen = new IsOpenForm
                {
                    TopLevel = false,
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.SizableToolWindow
                    //Dock = DockStyle.Fill
                };
                panelDesktop.Controls.Add(formOpen);
                panelDesktop.Tag = formOpen;
                formOpen.Show();
                formOpen.BringToFront();
            }
            else
            {
                formOpen.BringToFront();
            }
        }
        private void activateButton(object senderBtn, Color color)
        {
            //Button
            currentBtn = (IconButton)senderBtn;
            //currentBtn.BackColor = Color.FromArgb(37, 36, 81);
            //currentBtn.ForeColor = color;
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            //currentBtn.IconColor = color;
            //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

            //Left border button
            leftBorderBtn.BackColor = color;
            leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
            leftBorderBtn.Visible = true;
            leftBorderBtn.BringToFront();
        }
        private bool showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible.Equals(false))
            {
                hideSubMenu();
                return subMenu.Visible = true;
            }
            else
            {
                return subMenu.Visible = false;
            }
        }
        private void hideSubMenu()
        {
            panelSubMenuGeneral.Visible = false;
            panelSubReport.Visible = false;
            panelSubAjust.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOpenGeneral_Click(object sender, EventArgs e)
        {
            if (showSubMenu(panelSubMenuGeneral))
            {
                activateButton(sender, RGBColors.color3);
            }
            else
            {
                activateButton(sender, Color.Transparent);
            }
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            if (showSubMenu(panelSubReport))
            {
                activateButton(sender, RGBColors.color5);
            }
            else
            {
                activateButton(sender, Color.Transparent);
            }
        }

        private void btnAjust_Click(object sender, EventArgs e)
        {
            if (showSubMenu(panelSubAjust))
            {
                activateButton(sender, RGBColors.color4);
            }
            else
            {
                activateButton(sender, Color.Transparent);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenForm<formUser>();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.StartPosition = FormStartPosition.CenterScreen;
            if (WindowState.Equals(FormWindowState.Normal))
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenForm<formCategory>();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenForm<formProduct>();
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            formUserLogin masterContain = new formUserLogin();
            masterContain.Show();
            this.Hide();
        }

        private void bntCash_Click(object sender, EventArgs e)
        {
            OpenForm<formBoxConfig>();
        }

        private void btnOpenAgencyBox_Click(object sender, EventArgs e)
        {
            OpenForm<formOpenBox>();
        }
    }
}