using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Capa.Datos;

namespace Capa.Datos.ORM
{
    public class clsProduct
    {
        public Guid prodIntId { get; set; }
        public Guid? categoryIntId { get; set; }
        public Guid? presId { get; set; }
        public string proName { get; set; }
        public string prodCode { get; set; }
        public decimal prodPriceBuy { get; set; }
        public decimal prodPriceSales { get; set; }
        public DateTime proDate { get; set; }
        public int? proIva { get; set; }
        public int proStock { get; set; }
        public int proMinimalStock { get; set; }
        public bool proStatus { get; set; }

        public void SaveData(clsProduct clsProduct, Guid? updateKarIntId)
        {
            try
            {
                object valueCategories = new object();
                object valueTypePresentation = new object();
                if (clsProduct.categoryIntId == null)
                {
                    valueCategories = DBNull.Value;
                }
                else
                {
                    valueCategories = clsProduct.categoryIntId;
                }

                if (clsProduct.presId == null)
                {
                    valueTypePresentation = DBNull.Value;
                }
                else
                {
                    valueTypePresentation = clsProduct.presId;
                }

                Conexion.GDatos.BeginTransaction();

                Conexion.GDatos.Ejecutar("SP_IM_PRODUCT", clsProduct.prodIntId, valueCategories,
                                                          clsProduct.proName, clsProduct.prodCode,
                                                          clsProduct.prodPriceSales, clsProduct.proMinimalStock,
                                                          clsProduct.proStatus, clsProduct.proIva, clsProduct.presId);


                Guid typKardex = Guid.Parse(new UtilsRespository().GetData("SP_GET_TYPE_KARDEX", "TYP_KAR_NAME", "TYP_KAR_ID", "Entrada").ToString());

                if (updateKarIntId != null && updateKarIntId != Guid.Empty)
                {
                    Conexion.GDatos.Ejecutar("SP_IM_KADEX", updateKarIntId, clsProduct.prodIntId, typKardex,
                                                                            "Ingreso de producto " + clsProduct.proName,
                                                                            DateTime.Now, clsProduct.prodPriceBuy,
                                                                            clsProduct.proStock, clsProduct.proStock,
                                                                            clsProduct.proDate, DBNull.Value);
                }
                else
                {
                    Conexion.GDatos.Ejecutar("SP_IM_KADEX", Guid.NewGuid(), clsProduct.prodIntId, typKardex,
                                                                            "Ingreso de producto " + clsProduct.proName,
                                                                            DateTime.Now, clsProduct.prodPriceBuy,
                                                                            clsProduct.proStock, clsProduct.proStock,
                                                                            clsProduct.proDate, DBNull.Value);

                }

                Conexion.GDatos.CommitTransaction();
            }
            catch (Exception ex)
            {
                Conexion.GDatos.RollBackTransaction();
                throw ex;
            }
        }


        public void processSales(DataTable dtProduct, string numberInvoice, decimal amoutTotal, Guid userIntId, Guid typePayment)
        {
            try
            {
                Conexion.GDatos.BeginTransaction();

                Guid newSale = Guid.NewGuid();
                DateTime dateActual = DateTime.Now;

                Conexion.GDatos.Ejecutar("SP_I_SALES", newSale, Guid.Parse("C08E5991-E602-4101-A18F-AAD6AE03F583"), dateActual);

                Conexion.GDatos.Ejecutar("SP_I_INVOICE", Guid.NewGuid(), newSale, typePayment, numberInvoice, dateActual, amoutTotal);

                Guid typeKardex = Guid.Parse(new UtilsRespository().GetData("SP_GET_TYPE_KARDEX", "TYP_KAR_NAME", "TYP_KAR_ID", "Entrada").ToString());

                Guid typeKardeExit = Guid.Parse(new UtilsRespository().GetData("SP_GET_TYPE_KARDEX", "TYP_KAR_NAME", "TYP_KAR_ID", "Salida").ToString());

                Guid currentProductIntId = Guid.Empty;
                string currentProducName;
                int currentCantiProductTosale = 0;
                decimal currentPrice = decimal.Zero;
                ArrayList lsKarafected = new ArrayList();
                foreach (DataRow item in dtProduct.Rows)
                {
                    Guid.TryParse(item["PRO_INT_ID"].ToString(), out currentProductIntId);
                    currentCantiProductTosale = int.Parse(item["Cantidad"].ToString());
                    currentProducName = item["Nombre"].ToString();
                    currentPrice = decimal.Parse(item["Precio"].ToString());
                    DataTable dtKardexProduct = GetData("GET_PRODUCT_KARDEX", currentProductIntId, typeKardex);

                    Conexion.GDatos.Ejecutar("SP_I_SALES_DETAILS", Guid.NewGuid(), newSale, currentProductIntId, currentCantiProductTosale, currentPrice);

                    if (dtKardexProduct.Rows.Count > 0)
                    {
                        foreach (DataRow drKardexAfected in dtKardexProduct.Rows)
                        {
                            Guid currentKarAffected = Guid.Empty;
                            int currentCant;

                            Guid.TryParse(drKardexAfected["KAR_ID"].ToString(), out currentKarAffected);
                            lsKarafected.Add(currentKarAffected);
                            currentCant = int.Parse(drKardexAfected["Cantidad"].ToString());

                            if (currentCant <= currentCantiProductTosale)
                            {

                                insertKardexExit(currentProductIntId, typeKardeExit,
                                                 currentProducName, dateActual, currentPrice,
                                                 currentCant);

                                currentCantiProductTosale -= currentCant;

                                Conexion.GDatos.Ejecutar("SP_UPDATE_KAR", currentKarAffected, 0, dateActual);
                            }
                            else
                            {
                                if (currentCant > currentCantiProductTosale)
                                {
                                    //se inserta el movi de salida
                                    insertKardexExit(currentProductIntId, typeKardeExit,
                                                 currentProducName, dateActual, currentPrice,
                                                 currentCantiProductTosale);

                                    int quentity = currentCant - currentCantiProductTosale;
                                    Conexion.GDatos.Ejecutar("SP_UPDATE_KAR", currentKarAffected, quentity, DBNull.Value);

                                    currentCantiProductTosale = 0;
                                }
                                else
                                { }
                            }
                            if (currentCantiProductTosale == 0)
                            {
                                break;
                            }
                        }
                    }
                }
                foreach (var item in lsKarafected)
                {
                    Conexion.GDatos.Ejecutar("SP_I_SAL_KAR_AFECTERD", newSale, item);
                }
                Conexion.GDatos.CommitTransaction();
            }
            catch (Exception ex)
            {
                Conexion.GDatos.RollBackTransaction();
                throw ex;
            }
        }

        private void insertKardexExit(Guid currentProductIntId, Guid typeKardeExit, string currentProducName, DateTime dateActual, decimal currentPrice, int currentCantiProductTosale)
        {
            Conexion.GDatos.Ejecutar("SP_IM_KADEX", Guid.NewGuid(), currentProductIntId, typeKardeExit,
                                                                            "Salida de producto " + currentProducName,
                                                                            dateActual, currentPrice,
                                                                            currentCantiProductTosale, currentCantiProductTosale,
                                                                            dateActual, dateActual);
        }

        public DataTable GetData(string procedure, Guid product, Guid typeKarde)
        {
            return Conexion.GDatos.TraerDataTable(procedure, product, typeKarde);
        }
    }
}