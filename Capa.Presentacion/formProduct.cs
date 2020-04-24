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
    public partial class formProduct : Form
    {
        private clsProduct _clsProduct = new clsProduct();
        private UtilsRespository utilsRespository = new UtilsRespository();
        Guid currenProductIntId = Guid.Empty;
        Guid currentProductKardex = Guid.Empty;
        Guid typeKardex = Guid.Empty;
        ArrayList parameterToFilter = new ArrayList();
        int count = 0;
        private bool activateSearch = true;

        public formProduct()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
            disableEnableControls(true);
            TimeSumulate.Stop();
            isSearch();
        }

        private void formProduct_Load(object sender, EventArgs e)
        {
            loadCatecories();
            loadAllProduct();
            typeKardex = Guid.Parse(utilsRespository.GetData("SP_GET_TYPE_KARDEX", "TYP_KAR_NAME", "TYP_KAR_ID", "Entrada").ToString());
        }

        private void loadCatecories()
        {
            cmbCategories.DataSource = new BindingSource(utilsRespository.GetCombo("SP_GET_CATEGORY"), null);
            cmbCategories.DisplayMember = "key";
            cmbCategories.ValueMember = "Value";
        }

        private void loadAllProduct()
        {
            DataTable dt = utilsRespository.GetData("GET_PRODUCT");
            BindDataInGrid(dt);
        }

        private void disableEnableControls(bool activate)
        {
            clearControls();
            textPriceBuy.ReadOnly = activate;
            textPriceSales.ReadOnly = activate;
            btnAdd.Enabled = activate ? false : true;
            btnCancel.Enabled = activate ? false : true;
            dtExpirationProduct.Enabled = activate ? false : true;
            textMinimalStock.ReadOnly = activate;
            if (activate)
            {
                textName.BackColor = SystemColors.Control;
                textCode.BackColor = SystemColors.Control;
                textStock.BackColor = SystemColors.Control;
                textPriceBuy.BackColor = SystemColors.Control;
                textPriceSales.BackColor = SystemColors.Control;
                textMinimalStock.BackColor = SystemColors.Control;
            }
            else
            {
                textName.BackColor = Color.White;
                textPriceSales.BackColor = Color.White;
                textStock.BackColor = Color.White;
                textCode.BackColor = Color.White;
                textPriceBuy.BackColor = Color.White;
                textMinimalStock.BackColor = Color.White;

            }
            textName.BackColor = Color.White;
            cmbCategories.BackColor = Color.White;
        }

        private void clearControls()
        {
            textName.Text = string.Empty;
            textPriceBuy.Text = string.Empty;
            textMinimalStock.Text = string.Empty;
            textCode.Text = string.Empty;
            textPriceSales.Text = string.Empty;
            textStock.Text = string.Empty;
            if (cmbCategories.Items.Count > 0)
            {
                cmbCategories.SelectedIndex = 0;
            }
        }

        private void isSearch()
        {
            if (activateSearch)
            {
                if (dgAllProduct.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
                {
                    if (!cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()) && !textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("Nombre").StartsWith(textName.Text) && res.Field<Guid>("CAT_INT_ID") == Guid.Parse(cmbCategories.SelectedValue.ToString())
                                           select res;

                        BindDataInGrid(resultSearch.AsDataView().ToTable());

                    }
                    else if (!textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase) && cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res.Field<string>("Nombre").StartsWith(textName.Text)
                                           select res;

                        BindDataInGrid(resultSearch.AsDataView().ToTable());
                    }
                    else if (textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase) && cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                    {
                        loadAllProduct();
                    }
                    else if (textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase) && !cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                    {
                        var resultSearch = from res in dataExist.AsEnumerable()
                                           where res["CAT_INT_ID"].ToString() == cmbCategories.SelectedValue.ToString()
                                           select res;

                        BindDataInGrid(resultSearch.AsDataView().ToTable());
                    }
                    else
                    {
                        if (textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase) && cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                        {
                            loadAllProduct();
                        }
                    }
                }
                else
                {
                    //if (textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase) || !cmbCategories.SelectedValue.ToString().Equals(Guid.Empty.ToString()))
                    //{
                    //    loadAllProduct();
                    //}
                }
            }
        }

        private void BindDataInGrid(DataTable dt)
        {
            dgAllProduct.DataSource = dt;
            if (dgAllProduct.Rows.Count > 0 || dgAllProduct != null)
            {
                dgAllProduct.Columns["PRO_INT_ID"].Visible = false;
                dgAllProduct.Columns["CAT_INT_ID"].Visible = false;
                dgAllProduct.Columns["PRO_PRICE_SALES"].HeaderText = "Precio de Venta";

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
            isSearch();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            activateSearch = false;
            disableEnableControls(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result.Equals(DialogResult.Yes))
            {
                activateSearch = true;
                clearControls();
                disableEnableControls(true);
                if (dgAllProduct.Rows.Count.Equals(0))
                {
                    loadAllProduct();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                activateSearch = false;

                if (textName.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textCode.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textMinimalStock.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textPriceBuy.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textPriceSales.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    || textStock.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    MessageBox.Show("Campos incompletos!!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataTable dataExist = dgAllProduct.DataSource as DataTable;

                if (dataExist.Rows.Count > 0)
                {
                    var isExist = dataExist.AsEnumerable().Where(x => x["Nombre"].ToString() == textName.Text || x["Código"].ToString() == textName.Text).Select(x => x).FirstOrDefault();
                    if (isExist != null)
                    {
                        MessageBox.Show("Ya existe el producto que desea ingresar!!.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                _clsProduct.proName = textName.Text;
                _clsProduct.prodCode = textCode.Text;
                _clsProduct.prodPriceBuy = decimal.Parse(textPriceBuy.Text);
                _clsProduct.prodPriceSales = decimal.Parse(textPriceSales.Text);
                _clsProduct.proMinimalStock = int.Parse(textMinimalStock.Text);
                _clsProduct.proStock = int.Parse(textStock.Text);
                _clsProduct.proDate = dtExpirationProduct.Value;

                if (cmbCategories.SelectedValue.ToString() == Guid.Empty.ToString())
                {
                    _clsProduct.categoryIntId = null;
                }
                else
                {
                    _clsProduct.categoryIntId = Guid.Parse(cmbCategories.SelectedValue.ToString());
                }

                _clsProduct.proStatus = true;
                if (currenProductIntId == Guid.Empty)
                {
                    _clsProduct.prodIntId = Guid.NewGuid();
                    _clsProduct.SaveData(_clsProduct, null);
                }
                else
                {
                    _clsProduct.prodIntId = currenProductIntId;
                    _clsProduct.SaveData(_clsProduct, currentProductKardex);
                }

                currenProductIntId = Guid.Empty;
                disableEnableControls(true);
                loadAllProduct();

                if (currenProductIntId != Guid.Empty)
                {
                    MessageBox.Show("Producto actualizado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Producto ingresado con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                activateSearch = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            if (activateSearch)
            {
                isSearch();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void dgAllProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                parameterToFilter.Clear();
                Guid catCurrentValue = Guid.Empty;
                activateSearch = false;
                disableEnableControls(false);
                int currentRow = dgAllProduct.CurrentRow.Index;
                currenProductIntId = Guid.Parse(dgAllProduct.Rows[currentRow].Cells["PRO_INT_ID"].EditedFormattedValue.ToString());
                textName.Text = dgAllProduct.Rows[currentRow].Cells["Nombre"].EditedFormattedValue.ToString();
                textCode.Text = dgAllProduct.Rows[currentRow].Cells["Código"].EditedFormattedValue.ToString();
                Guid.TryParse(dgAllProduct.Rows[currentRow].Cells["CAT_INT_ID"].EditedFormattedValue.ToString(), out catCurrentValue);
                cmbCategories.SelectedIndex = GetIndexCat(catCurrentValue);
                ckbStatus.Checked = (bool)dgAllProduct.Rows[currentRow].Cells["Estado"].EditedFormattedValue;
                textPriceSales.Text = dgAllProduct.Rows[currentRow].Cells["PRO_PRICE_SALES"].EditedFormattedValue.ToString();
                textMinimalStock.Text = dgAllProduct.Rows[currentRow].Cells["PRO_MINIMAL_STOCK"].EditedFormattedValue.ToString();


                DataTable dtKardexProduct = _clsProduct.GetData("GET_PRODUCT_KARDEX", currenProductIntId, typeKardex);
                dgProductExist.DataSource = dtKardexProduct;

                panelSourseProducts.Visible = true;


                btnClean.Visible = true;
            }
            catch
            {
            }
        }

        private void dgProductExist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = dgAllProduct.CurrentRow.Index;
            Guid.TryParse(dgAllProduct.Rows[currentRow].Cells["KAR_ID"].EditedFormattedValue.ToString(), out currentProductKardex);

            
        }

        private int GetIndexCat(Guid catIntId)
        {
            int count = 0;
            if (catIntId.Equals(Guid.Empty))
            {
                return 0;
            }
            else
            {
                DataTable dt = utilsRespository.GetData("SP_GET_CATEGORY");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        count += 1;
                        if (item["CAT_INT_ID"].ToString().Equals(catIntId.ToString()))
                        {
                            break;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }

            return count;
        }
    }
}