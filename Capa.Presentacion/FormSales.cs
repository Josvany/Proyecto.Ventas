using Capa.Datos;
using Capa.Datos.ORM;
using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using System.Net;

namespace Capa.Presentacion
{
    public partial class FormSales : Form
    {
        UtilsRespository utilsRespository = new UtilsRespository();
        clsProduct _clsProduct = new clsProduct();
        DataTable dtSearchProduct = new DataTable();
        Guid currentProductSelected = Guid.Empty;
        Guid currentProductSelectedEdit = Guid.Empty;
        decimal currentPrice;
        string currentPresentation;
        bool isEdited = false;
        int cantRestante, cantPedido, ActualCantidadSales;
        decimal priceCurrentProduct = decimal.Zero;
        public FormSales()
        {
            InitializeComponent();
            Conexion.IniciarSesion();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Transparent;
            loadAllProduct();
            //panelSourseProducts.Visible = true;
            BindingGridsales(createSchemaDtSales());
            getInvNumber();
            loadTypePayment();
        }

        private void loadTypePayment()
        {
            cmbTypePayment.DataSource = new BindingSource(utilsRespository.GetCombo("GET_TYPE_PAYMENT"), null);
            cmbTypePayment.DisplayMember = "key";
            cmbTypePayment.ValueMember = "Value";
        }

        private void getInvNumber()
        {
            DataTable dtInv = utilsRespository.GetData("GET_INVOCE");

            var numberFac = dtInv.AsEnumerable().Select(x => x["INV_NUMBER"]).DefaultIfEmpty(0).Max(x => Convert.ToInt32(x));

            textInvNumber.Text = Convert.ToString(numberFac + 1).PadLeft(10, '0');

        }
        private void loadAllProduct()
        {
            DataTable dt = utilsRespository.GetData("GET_PRODUCT");
            dtSearchProduct = dt;
            bindigGridAllProduct(dt);
        }

        private void BindingGridsales(DataTable dt)
        {
            dtListProductToSales.DataSource = dt;
            if (dt != null)
            {
                dtListProductToSales.Columns["PRO_INT_ID"].Visible = false;
            }

        }

        private void bindigGridAllProduct(DataTable dt)
        {
            dgallProduct.DataSource = dt;

            if (dgallProduct.Rows.Count > 0 || dgallProduct != null)
            {
                dgallProduct.Columns["PRO_INT_ID"].Visible = false;
                dgallProduct.Columns["CAT_INT_ID"].Visible = false;
                dgallProduct.Columns["IVA"].Visible = false;
                dgallProduct.Columns["ESTADO"].Visible = false;
                dgallProduct.Columns["PRO_MINIMAL_STOCK"].Visible = false;
                dgallProduct.Columns["CANTIDAD"].Visible = true;
                dgallProduct.Columns["CÓDIGO"].Visible = false;
                dgallProduct.ColumnHeadersVisible = false;
                dgallProduct.RowHeadersVisible = false;
                dgallProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void SearchProduct()
        {
            if (dgallProduct.DataSource is DataTable dataExist && dataExist.Rows.Count > 0)
            {
                if (!textSearch.Text.Equals(string.Empty, StringComparison.CurrentCultureIgnoreCase))
                {
                    var resultSearch = from res in dataExist.AsEnumerable()
                                       where res.Field<string>("Nombre").Contains(textSearch.Text) || res.Field<string>("Código").Contains(textSearch.Text)
                                       select res;

                    if (resultSearch.AsDataView().ToTable().Rows.Count > 0)
                    {
                        panelSourseProducts.Visible = true;
                    }
                    bindigGridAllProduct(resultSearch.AsDataView().ToTable());
                }
                else
                {
                    panelSourseProducts.Visible = false;
                    currentProductSelected = Guid.Empty;
                    bindigGridAllProduct(dtSearchProduct);
                }
            }
            else
            {
                panelSourseProducts.Visible = false;
                currentProductSelected = Guid.Empty;
                bindigGridAllProduct(dtSearchProduct);
            }
        }

        private void dgallProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgallProduct.CurrentRow.Index;
            Guid.TryParse(dgallProduct.Rows[index].Cells["PRO_INT_ID"].EditedFormattedValue.ToString(), out currentProductSelected);
            textProductName.Text = dgallProduct.Rows[index].Cells["Nombre"].EditedFormattedValue.ToString();
            currentPrice = decimal.Parse(dgallProduct.Rows[index].Cells["PRO_PRICE_SALES"].EditedFormattedValue.ToString());
            currentPresentation = dgallProduct.Rows[index].Cells["PRES_NAME"].EditedFormattedValue.ToString();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private DataTable createSchemaDtSales()
        {
            DataTable dtReturnValue = new DataTable();

            //dtReturnValue.Columns.Add("IDSales", typeof(Guid));
            dtReturnValue.Columns.Add("PRO_INT_ID", typeof(Guid));
            dtReturnValue.Columns.Add("Nombre", typeof(string));
            dtReturnValue.Columns.Add("Cantidad", typeof(int));
            dtReturnValue.Columns.Add("Precio", typeof(decimal));
            dtReturnValue.Columns.Add("Presentacion", typeof(string));
            dtReturnValue.Columns.Add("Total", typeof(decimal));

            return dtReturnValue;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProductSelected.Equals(Guid.Empty) && currentProductSelectedEdit.Equals(Guid.Empty))
                {
                    throw new Exception("Debe selecionar un producto");
                }

                DataTable percistanceData = dtListProductToSales.DataSource as DataTable;
                DataRow dr = percistanceData.NewRow();
                int totalExist = dtSearchProduct.AsEnumerable().Where(x => (Guid)x["PRO_INT_ID"] == currentProductSelected).Select(x => (int)x["Cantidad"]).SingleOrDefault();
                cantPedido = int.Parse(textCantidad.Text);

                if (!isEdited)
                {
                    var isExist = percistanceData.AsEnumerable().Where(x => (Guid)x["PRO_INT_ID"] == currentProductSelected).Select(x => x).FirstOrDefault();
                    if (isExist != null)
                    {
                        MessageBox.Show("El producto ya se ingreso si desea cambiar la cantidad " + Environment.NewLine + " solo actualizar dicho registro."
                                        , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    ActualCantidadSales = percistanceData.AsEnumerable().Where(x => (Guid)x["PRO_INT_ID"] == currentProductSelectedEdit).Select(x => (int)x["Cantidad"]).SingleOrDefault();
                    priceCurrentProduct = percistanceData.AsEnumerable().Where(x => (Guid)x["PRO_INT_ID"] == currentProductSelectedEdit).Select(x => (decimal)x["Precio"]).SingleOrDefault();
                    totalExist += ActualCantidadSales;
                }

                if (cantPedido > totalExist)
                {
                    throw new Exception("La cantidad que desea vender es mayor a la de existencia");
                }
                cantRestante = totalExist - cantPedido;

                if (!isEdited)
                {
                    dr["PRO_INT_ID"] = currentProductSelected;
                    dr["Nombre"] = textProductName.Text;
                    dr["Cantidad"] = cantPedido;
                    dr["Precio"] = currentPrice;
                    dr["Presentacion"] = "50 ML";
                    dr["Total"] = decimal.Parse(textCantidad.Text) * currentPrice;
                    percistanceData.Rows.Add(dr);
                }
                else
                {
                    foreach (DataRow item in percistanceData.Rows)
                    {
                        if (Guid.Parse(item["PRO_INT_ID"].ToString()).Equals(currentProductSelectedEdit))
                        {
                            item["Cantidad"] = cantPedido;
                            item["Total"] = cantPedido * priceCurrentProduct;
                        }
                    }
                }
                BindingGridsales(percistanceData);
                isEdited = false;
                updateCantProductExist(cantRestante);
                sumTotalSales();
                clearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sumTotalSales()
        {
            DataTable percistanceData = dtListProductToSales.DataSource as DataTable;
            if (percistanceData.Rows.Count > 0)
            {
                textTotal.Text = (percistanceData.AsEnumerable().Select(x => (int)x["Cantidad"] * (decimal)x["Precio"]).Sum()).ToString();
            }
            else
            {
                textTotal.Text = string.Empty;
            }
        }

        private void updateCantProductExist(int CantTotal)
        {
            foreach (DataRow item in dtSearchProduct.Rows)
            {
                if (Guid.Parse(item["PRO_INT_ID"].ToString()).Equals(currentProductSelected))
                {
                    item["Cantidad"] = CantTotal;
                }
            }
        }

        private void clearControls()
        {
            currentProductSelected = Guid.Empty;
            currentProductSelectedEdit = Guid.Empty;
            textProductName.Text = string.Empty;
            textCantidad.Text = string.Empty;
            textSearch.Text = string.Empty;
        }

        private void panelSourseProducts_Leave(object sender, EventArgs e)
        {
            hidenPanenlSearchProduct();
        }

        private void dgallProduct_MouseLeave(object sender, EventArgs e)
        {
            hidenPanenlSearchProduct();
        }
        private void hidenPanenlSearchProduct()
        {
            if (currentProductSelected != Guid.Empty)
            {
                panelSourseProducts.Visible = false;
                //textSearch.Text = string.Empty;
            }
        }

        private void dtListProductToSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != this.dtListProductToSales.Columns["S"].Index && e.ColumnIndex != this.dtListProductToSales.Columns["R"].Index && e.ColumnIndex != this.dtListProductToSales.Columns["EL"].Index)
            {
                isEdited = true;
                int index = dtListProductToSales.CurrentRow.Index;
                Guid.TryParse(dtListProductToSales.Rows[index].Cells["PRO_INT_ID"].EditedFormattedValue.ToString(), out currentProductSelectedEdit);
                Guid.TryParse(dtListProductToSales.Rows[index].Cells["PRO_INT_ID"].EditedFormattedValue.ToString(), out currentProductSelected);
                textProductName.Text = dtListProductToSales.Rows[index].Cells["Nombre"].EditedFormattedValue.ToString();
                currentPrice = decimal.Parse(dtListProductToSales.Rows[index].Cells["Precio"].EditedFormattedValue.ToString());
                currentPresentation = dtListProductToSales.Rows[index].Cells["Presentacion"].EditedFormattedValue.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProduct();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtProductToSale = dtListProductToSales.DataSource as DataTable;

                _clsProduct.processSales(dtProductToSale, textInvNumber.Text,
                    decimal.Parse(textTotal.Text), Program.UserIntId, Guid.Parse(cmbTypePayment.SelectedValue.ToString()));

                clearControls();
                MessageBox.Show("Proceso exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilsRespository.blockLeter(e);
        }

        private void dtListProductToSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtListProductToSales.CurrentRow.Index;
                Guid.TryParse(dtListProductToSales.Rows[index].Cells["PRO_INT_ID"].EditedFormattedValue.ToString(), out currentProductSelectedEdit);
                Guid.TryParse(dtListProductToSales.Rows[index].Cells["PRO_INT_ID"].EditedFormattedValue.ToString(), out currentProductSelected);
                int totalExist = dtSearchProduct.AsEnumerable().Where(x => (Guid)x["PRO_INT_ID"] == currentProductSelectedEdit).Select(x => (int)x["Cantidad"]).SingleOrDefault();
                DataTable percistanceData = dtListProductToSales.DataSource as DataTable;
                ActualCantidadSales = int.Parse(dtListProductToSales.Rows[index].Cells["Cantidad"].EditedFormattedValue.ToString());
                priceCurrentProduct = decimal.Parse(dtListProductToSales.Rows[index].Cells["Precio"].EditedFormattedValue.ToString());
                if (e.ColumnIndex == this.dtListProductToSales.Columns["S"].Index)
                {
                    totalExist += ActualCantidadSales;
                    cantPedido = ActualCantidadSales;
                    cantPedido += 1;

                    if (cantPedido > totalExist)
                    {
                        throw new Exception("La cantidad que desea vender es mayor a la de existencia");
                    }
                    cantRestante = totalExist - cantPedido;

                    foreach (DataRow item in percistanceData.Rows)
                    {
                        if (Guid.Parse(item["PRO_INT_ID"].ToString()).Equals(currentProductSelectedEdit))
                        {
                            item["Cantidad"] = cantPedido;
                            item["Total"] = cantPedido * priceCurrentProduct;
                        }
                    }

                    BindingGridsales(percistanceData);

                    updateCantProductExist(cantRestante);
                    sumTotalSales();
                }
                if (e.ColumnIndex == this.dtListProductToSales.Columns["R"].Index)
                {
                    totalExist += ActualCantidadSales;
                    cantPedido = ActualCantidadSales;
                    cantPedido -= 1;

                    if (cantPedido > totalExist)
                    {
                        throw new Exception("La cantidad que desea vender es mayor a la de existencia");
                    }
                    cantRestante = totalExist - cantPedido;

                    foreach (DataRow item in percistanceData.Rows)
                    {
                        if (Guid.Parse(item["PRO_INT_ID"].ToString()).Equals(currentProductSelectedEdit))
                        {
                            item["Cantidad"] = cantPedido;
                            item["Total"] = cantPedido * priceCurrentProduct;
                        }
                    }
                    if (cantPedido == 0)
                    {
                        percistanceData.AsEnumerable().Where(r => r.Field<Guid>("PRO_INT_ID") == currentProductSelectedEdit).ToList().ForEach(row => row.Delete());
                    }
                    BindingGridsales(percistanceData);

                    updateCantProductExist(cantRestante);
                    sumTotalSales();
                }

                if (e.ColumnIndex == this.dtListProductToSales.Columns["EL"].Index)
                {
                    cantRestante = totalExist + ActualCantidadSales;
                    percistanceData.AsEnumerable().Where(r => r.Field<Guid>("PRO_INT_ID") == currentProductSelectedEdit).ToList().ForEach(row => row.Delete());
                    BindingGridsales(percistanceData);
                    updateCantProductExist(cantRestante);
                    sumTotalSales();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearControls();
        }
    }
}