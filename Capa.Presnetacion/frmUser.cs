using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Capa.Datos;
using Capa.Datos.ORM;

namespace Capa.Presnetacion
{
    public partial class frmUser : Form
    {
        private clsRole _clsRole = new clsRole();

        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            Conexion.IniciarSesion(".", "DB_FARMACY", "sa", "123456");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _clsRole.rolIntId = Guid.NewGuid();
                _clsRole.rolName = txtName.Text;
                _clsRole.Insert(_clsRole);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
