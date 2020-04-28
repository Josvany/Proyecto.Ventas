using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Collections;

namespace Capa.Presentacion
{
    public partial class formOpenBox : Form
    {
        private UtilsRespository utilsRespository = new UtilsRespository();
        private clsAgencyBox clsAgencyBox = new clsAgencyBox();
        public formOpenBox()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
        }

        private void formOpenBox_Load(object sender, EventArgs e)
        {
            loadAgencyBox();
        }

        private void loadAgencyBox()
        {
            cmbCategories.DataSource = new BindingSource(utilsRespository.GetCombo("SP_GET_AGENCY_BOX"), null);
            cmbCategories.DisplayMember = "key";
            cmbCategories.ValueMember = "Value";
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                {
                    MessageBox.Show("Debe seleccionar una caja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (textAmount.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("Favor introducir monto inicial", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsAgencyBox.saveData(Guid.NewGuid(), Guid.Parse(cmbCategories.SelectedValue.ToString()),
                                      Program.UserIntId, decimal.Parse(textAmount.Text));


                MessageBox.Show("Caja abierta con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilsRespository.blockLeter(e);
        }
    }
}
