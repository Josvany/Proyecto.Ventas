using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Capa.Presentacion
{
    public partial class formBoxConfig : Form
    {
        private UtilsRespository utilsRespository = new UtilsRespository();
        private clsAgencyBox _clsAgencyBox = new clsAgencyBox();
        bool activateSearch = true;
        bool isEdited = true;
        string nameAux;
        Guid currenAgencyBoxIntId = Guid.Empty;
        public formBoxConfig()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
            disableEnableControls(true);
        }

        private void formBox_Load(object sender, EventArgs e)
        {
            GetAgencyBox();
        }
        private void GetAgencyBox()
        {
            dgAllBoxes.DataSource = utilsRespository.GetData("SP_GET_AGENCY_BOX");

            if (dgAllBoxes != null && dgAllBoxes.Rows.Count > 0)
            {
                dgAllBoxes.Columns["BOX_INT_ID"].Visible = false;
                dgAllBoxes.Columns["BOX_NAME"].HeaderText = "Nombre Caja";
                dgAllBoxes.Columns["BOX_STATUS"].HeaderText = "Estado";
            }
        }

        private void disableEnableControls(bool activate)
        {
            clearControls();
            ckbStatus.Enabled = activate ? false : true;
            btnAdd.Enabled = activate ? false : true;
            btnCancel.Enabled = activate ? false : true;
            textNombre.BackColor = Color.White;
        }
        private void clearControls()
        {
            textNombre.Text = string.Empty;
            ckbStatus.Checked = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            activateSearch = false;
            isEdited = false;
            disableEnableControls(false);
            textNombre.Focus();
            if (dgAllBoxes.Rows.Count.Equals(0))
            {
                GetAgencyBox();
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
                GetAgencyBox();
                currenAgencyBoxIntId = Guid.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("Campos incompletos!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (isEdited)
                {
                    if (!textNombre.Text.Equals(nameAux))
                    {
                        validateAgencyBox();
                    }
                }
                else
                {
                    validateAgencyBox();
                }

                if (currenAgencyBoxIntId.Equals(Guid.Empty))
                {
                    _clsAgencyBox.boxIntId = Guid.NewGuid();
                }
                else
                {
                    _clsAgencyBox.boxIntId = currenAgencyBoxIntId;
                }
                _clsAgencyBox.boxName = textNombre.Text;
                _clsAgencyBox.boxStatus = ckbStatus.Checked;
                _clsAgencyBox.saveData(_clsAgencyBox);
                
                disableEnableControls(true);
                GetAgencyBox();

                if (currenAgencyBoxIntId != Guid.Empty)
                {
                    MessageBox.Show("Caja actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Caja ingresada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                currenAgencyBoxIntId = Guid.Empty;
                activateSearch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validateAgencyBox()
        {
            DataTable dataExist = dgAllBoxes.DataSource as DataTable;

            if (dataExist.Rows.Count > 0)
            {
                var isExist = dataExist.AsEnumerable().Where(x => x["BOX_NAME"].ToString() == textNombre.Text).Select(x => x).FirstOrDefault();
                if (isExist != null)
                {
                    MessageBox.Show("La caja ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgAllBoxes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                disableEnableControls(false);
                isEdited = true;
                int currentRow = dgAllBoxes.CurrentRow.Index;
                currenAgencyBoxIntId = Guid.Parse(dgAllBoxes.Rows[currentRow].Cells["BOX_INT_ID"].EditedFormattedValue.ToString());
                textNombre.Text = dgAllBoxes.Rows[currentRow].Cells["BOX_NAME"].EditedFormattedValue.ToString();
                ckbStatus.Checked = (bool)dgAllBoxes.Rows[currentRow].Cells["BOX_STATUS"].EditedFormattedValue;
                nameAux = textNombre.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search()
        {
            if (activateSearch)
            {
                if (dgAllBoxes.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
                {
                    if (!textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("BOX_NAME").StartsWith(textNombre.Text)
                                           select res;

                        DataView view = resultSearch.AsDataView();

                        DataTable dtResulFinally = view.ToTable();
                        if (dtResulFinally.Rows.Count > 0)
                        {
                            dgAllBoxes.DataSource = dtResulFinally;
                        }
                        else
                        {
                            dgAllBoxes.DataSource = null;
                        }
                    }
                    else
                    {
                        if (textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                        {
                            GetAgencyBox();
                        }
                    }
                }
                else
                {
                    if (textNombre.Text.Equals(string.Empty))
                    {
                        GetAgencyBox();
                    }
                }
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}