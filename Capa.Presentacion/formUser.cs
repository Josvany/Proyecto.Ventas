using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Capa.Presentacion
{
    public partial class formUser : Form
    {
        private clsUser _clsUser = new clsUser();
        private Encriptacion encriptacion = new Encriptacion();
        private UtilsRespository utilsRespository = new UtilsRespository();
        Guid currenUserIntId = Guid.Empty;
        int count = 0;
        private bool activateSearch = true;
        public formUser()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
            disableEnableControls(true);
            TimeSumulate.Stop();
            isEnableSearch();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {
                loadRol();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadRol()
        {
            cmbRol.DisplayMember = "ROL_NAME";
            cmbRol.ValueMember = "ROL_INT_ID";
            cmbRol.DataSource = utilsRespository.GetData("GET_ROLES");
        }
        private void loadAllUser()
        {
            dgAllUser.DataSource = utilsRespository.GetData("SP_GET_USER");
            if (dgAllUser.Rows.Count > 0 || dgAllUser != null)
            {
                dgAllUser.Columns["USE_INT_ID"].Visible = false;
                dgAllUser.Columns["ROL_INT_ID"].Visible = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textUser.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textPass.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("Campos incompletos!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!textPass.Text.Equals(textConfirmPass.Text, StringComparison.InvariantCulture))
                {
                    MessageBox.Show("Contrañenas deben coincidir", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dataExist = dgAllUser.DataSource as DataTable;

                if (dataExist.Rows.Count > 0)
                {
                    var isExist = dataExist.AsEnumerable().Where(x => x["Usuario"].ToString() == textUser.Text).Select(x => x).FirstOrDefault();
                    if (isExist != null)
                    {
                        MessageBox.Show("El usuario ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (currenUserIntId == Guid.Empty)
                {
                    _clsUser.userIntIdValue = Guid.NewGuid();
                }
                else
                {
                    _clsUser.userIntIdValue = currenUserIntId;
                }
                _clsUser.userNameValue = textNombre.Text;
                _clsUser.userLoginValue = textUser.Text;
                _clsUser.userPasswordValue = encriptacion.Encriptar(textPass.Text);
                _clsUser.rolIntIdValue = Guid.Parse(cmbRol.SelectedValue.ToString());
                _clsUser.userStatusValue = true;
                _clsUser.Insert(_clsUser);
                currenUserIntId = Guid.Empty;
                disableEnableControls(true);
                loadAllUser();

                if (currenUserIntId != Guid.Empty)
                {
                    MessageBox.Show("Usuario actualizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Usuario ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                activateSearch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disableEnableControls(bool activate)
        {
            clearControls();
            textNombre.ReadOnly = activate;
            textPass.ReadOnly = activate;
            cmbRol.Enabled = activate ? false : true;
            btnAdd.Enabled = activate ? false : true;
            btnCancel.Enabled = activate ? false : true;
            textConfirmPass.ReadOnly = activate;
            if (activate)
            {
                textNombre.BackColor = SystemColors.Control;
                textPass.BackColor = SystemColors.Control;
                textConfirmPass.BackColor = SystemColors.Control;
                cmbRol.BackColor = SystemColors.Control;
            }
            else
            {
                textNombre.BackColor = Color.White;
                textPass.BackColor = Color.White;
                textConfirmPass.BackColor = Color.White;
                cmbRol.BackColor = Color.White;
            }

            textUser.BackColor = Color.White;
        }

        private void clearControls()
        {
            textNombre.Text = string.Empty;
            textUser.Text = string.Empty;
            textPass.Text = string.Empty;
            textConfirmPass.Text = string.Empty;
            if (cmbRol.Items.Count > 0)
            {
                cmbRol.SelectedIndex = 0;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            activateSearch = false;
            disableEnableControls(false);
            textUser.Focus();
            if (dgAllUser.Rows.Count.Equals(0))
            {
                loadAllUser();
            }
        }
        private void dgAllUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                activateSearch = false;
                disableEnableControls(false);
                int currentRow = dgAllUser.CurrentRow.Index;
                currenUserIntId = Guid.Parse(dgAllUser.Rows[currentRow].Cells["USE_INT_ID"].EditedFormattedValue.ToString());
                textNombre.Text = dgAllUser.Rows[currentRow].Cells["Nombre"].EditedFormattedValue.ToString();
                textUser.Text = dgAllUser.Rows[currentRow].Cells["Usuario"].EditedFormattedValue.ToString();
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                activateSearch = true;
                clearControls();
                disableEnableControls(true);
                if (dgAllUser.Rows.Count.Equals(0))
                {
                    loadAllUser();
                }
            }
        }

        private void TimeSumulate_Tick(object sender, EventArgs e)
        {
            btnSearch.BackColor = SystemColors.Control;
            count += 1;
            if (count.Equals(3))
            {
                btnSearch.BackColor = SystemColors.ButtonHighlight;
                TimeSumulate.Stop();
                TimeSumulate.Dispose();
                count = 0;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            TimeSumulate.Start();
            isEnableSearch();
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {
            if (activateSearch)
            {
                btnSearch_Click(null, null);
            }
        }

        private void isEnableSearch()
        {
            if (activateSearch)
            {
                if (dgAllUser.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
                {
                    if (!textUser.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("Usuario").StartsWith(textUser.Text)
                                           select res;

                        DataView view = resultSearch.AsDataView();

                        DataTable dtResulFinally = view.ToTable();
                        if (dtResulFinally.Rows.Count > 0)
                        {
                            dgAllUser.DataSource = dtResulFinally;
                        }
                        else
                        {
                            dgAllUser.DataSource = null;
                        }
                    }
                    else
                    {
                        if (textUser.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                        {
                            loadAllUser();
                        }
                    }
                }
                else
                {
                    if (textUser.Text.Equals(string.Empty))
                    {
                        loadAllUser();
                    }
                }
            }
        }
    }
}