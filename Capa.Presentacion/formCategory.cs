using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Capa.Presentacion
{
    public partial class formCategory : Form
    {
        private clsCategory _clsCategory = new clsCategory();
        private UtilsRespository utilsRespository = new UtilsRespository();
        bool activateSearch = true;
        Guid currentCategoryIntId = Guid.Empty;
        int count = 0;
        public formCategory()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
            disableEnableControls(true);
            tm.Stop();
            isEnableSearch();
        }

        private void formCategory_Load(object sender, EventArgs e)
        {

        }
        private void getAllCategory()
        {
            dgAllCategory.DataSource = utilsRespository.GetData("SP_GET_CATEGORY");
            if (dgAllCategory.Rows.Count > 0 || dgAllCategory != null)
            {
                dgAllCategory.Columns["CAT_INT_ID"].Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tm.Start();
            isEnableSearch();
        }

        private void tm_Tick(object sender, EventArgs e)
        {
            btnSearch.BackColor = SystemColors.Control;
            count += 1;
            if (count.Equals(3))
            {
                btnSearch.BackColor = SystemColors.ButtonHighlight;
                tm.Stop();
                tm.Dispose();
                count = 0;
            }
        }

        private void disableEnableControls(bool activate)
        {
            clearControls();
            textSystemName.ReadOnly = activate;
            ckbStatus.Enabled = activate ? false : true;
            btnAdd.Enabled = activate ? false : true;
            btnCancel.Enabled = activate ? false : true;
            if (activate)
            {
                textSystemName.BackColor = SystemColors.Control;
            }
            else
            {
                textSystemName.BackColor = Color.White;
            }
            textNombre.BackColor = Color.White;
        }
        private void clearControls()
        {
            textNombre.Text = string.Empty;
            textSystemName.Text = string.Empty;
            ckbStatus.Checked = true;
        }

        private void isEnableSearch()
        {
            if (activateSearch)
            {
                if (dgAllCategory.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
                {
                    if (!textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("Nombre").StartsWith(textNombre.Text)
                                           select res;

                        DataView view = resultSearch.AsDataView();

                        DataTable dtResulFinally = view.ToTable();
                        if (dtResulFinally.Rows.Count > 0)
                        {
                            dgAllCategory.DataSource = dtResulFinally;
                        }
                        else
                        {
                            dgAllCategory.DataSource = null;
                        }
                    }
                    else
                    {
                        if (textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                        {
                            getAllCategory();
                        }
                    }
                }
                else
                {
                    if (textNombre.Text.Equals(string.Empty))
                    {
                        getAllCategory();
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            activateSearch = false;
            disableEnableControls(false);
            textNombre.Focus();
            if (dgAllCategory.Rows.Count.Equals(0))
            {
                getAllCategory();
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
                if (dgAllCategory.Rows.Count.Equals(0))
                {
                    getAllCategory();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textSystemName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("Campos incompletos!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataExist = dgAllCategory.DataSource as DataTable;

                if (currentCategoryIntId.Equals(Guid.Empty))
                {
                    if (dataExist.Rows.Count > 0)
                    {
                        var isExist = dataExist.AsEnumerable().Where(x => x["Nombre"].ToString() == textNombre.Text || x["Código"].ToString() == textSystemName.Text).Select(x => x).FirstOrDefault();
                        if (isExist != null)
                        {
                            MessageBox.Show("El categoria con nombre o código ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }

                if (currentCategoryIntId.Equals(Guid.Empty))
                {
                    _clsCategory.categoryIntId = Guid.NewGuid();
                }
                else
                {
                    _clsCategory.categoryIntId = currentCategoryIntId;
                }
                _clsCategory.categoryName = textNombre.Text;
                _clsCategory.categoryCode = textSystemName.Text;
                _clsCategory.categoryStatus = ckbStatus.Checked;
                _clsCategory.saveData(_clsCategory);
                
                disableEnableControls(true);
                getAllCategory();
                if (currentCategoryIntId != Guid.Empty)
                {
                    MessageBox.Show("Categoria actualizada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Categoria ingresada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                currentCategoryIntId = Guid.Empty;
                activateSearch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgAllCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                disableEnableControls(false);
                int currentRow = dgAllCategory.CurrentRow.Index;
                currentCategoryIntId = Guid.Parse(dgAllCategory.Rows[currentRow].Cells[0].EditedFormattedValue.ToString());
                textNombre.Text = dgAllCategory.Rows[currentRow].Cells[1].EditedFormattedValue.ToString();
                textSystemName.Text = dgAllCategory.Rows[currentRow].Cells[2].EditedFormattedValue.ToString();
                ckbStatus.Checked = (bool)dgAllCategory.Rows[currentRow].Cells[3].EditedFormattedValue;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
    }
}