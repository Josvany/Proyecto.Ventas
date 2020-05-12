using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace Capa.Presentacion
{
    public partial class formPresentation : Form
    {
        UtilsRespository utilsRespository = new UtilsRespository();
        clsPresentacion _clsPresentacion = new clsPresentacion();
        bool activateSearch = true;
        int count = 0;
        string auxName;
        private bool isEdited = false;
        Guid currentTypePre = Guid.Empty;
        public formPresentation()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
            disableEnableControls(true);
            tm.Stop();
            Search();
        }

        private void formPresentation_Load(object sender, EventArgs e)
        {

        }

        private void getTypePresentation()
        {
            dgAllCategory.DataSource = utilsRespository.GetData("SP_GET_TYPE_PRESENTATION");
            if (dgAllCategory.Rows.Count > 0 || dgAllCategory != null)
            {
                dgAllCategory.Columns["PRES_ID"].Visible = false;
                dgAllCategory.ColumnHeadersVisible = false;
                dgAllCategory.RowHeadersVisible = false;
            }
        }

        private void disableEnableControls(bool activate)
        {
            clearControls();
            btnAdd.Enabled = activate ? false : true;
            btnCancel.Enabled = activate ? false : true;
            textNombre.BackColor = Color.White;
        }
        private void clearControls()
        {
            textNombre.Text = string.Empty;
        }


        private void Search()
        {
            if (activateSearch)
            {
                if (dgAllCategory.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
                {
                    if (!textNombre.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("PRES_NAME").StartsWith(textNombre.Text)
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
                            getTypePresentation();
                        }
                    }
                }
                else
                {
                    if (textNombre.Text.Equals(string.Empty))
                    {
                        getTypePresentation();
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isEdited = false;
            activateSearch = false;
            disableEnableControls(false);
            textNombre.Focus();
            if (dgAllCategory.Rows.Count.Equals(0))
            {
                getTypePresentation();
            }
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
                    getTypePresentation();
                }
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
                    if (!auxName.Equals(textNombre.Text))
                    {
                        validationExists();
                    }
                }
                else
                {
                    validationExists();
                }

                if (currentTypePre.Equals(Guid.Empty))
                {
                    _clsPresentacion.preId = Guid.NewGuid();
                }
                else
                {
                    _clsPresentacion.preId   = currentTypePre;
                }
                _clsPresentacion.preName = textNombre.Text.ToUpper();
                _clsPresentacion.saveData(_clsPresentacion);

                disableEnableControls(true);
                getTypePresentation();
                if (currentTypePre != Guid.Empty)
                {
                    MessageBox.Show("Ingreso correcto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Actualización correcta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                currentTypePre = Guid.Empty;
                activateSearch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validationExists()
        {
            DataTable dataExist = dgAllCategory.DataSource as DataTable;

            if (currentTypePre.Equals(Guid.Empty))
            {
                if (dataExist.Rows.Count > 0)
                {
                    var isExist = dataExist.AsEnumerable().Where(x => x["PRES_NAME"].ToString() == textNombre.Text).Select(x => x).FirstOrDefault();
                    if (isExist != null)
                    {
                        MessageBox.Show("El categoria con nombre o código ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void dgAllCategory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                isEdited = true;
                activateSearch = false;
                disableEnableControls(false);
                int currentRow = dgAllCategory.CurrentRow.Index;
                currentTypePre = Guid.Parse(dgAllCategory.Rows[currentRow].Cells["PRES_ID"].EditedFormattedValue.ToString());
                textNombre.Text = dgAllCategory.Rows[currentRow].Cells["PRES_NAME"].EditedFormattedValue.ToString();
                auxName = textNombre.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
