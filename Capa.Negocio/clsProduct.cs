﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Capa.Datos;
using Capa.Datos.ORM;

namespace Capa.Datos.ORM
{
    public class clsProduct
    {
        public Guid prodIntId { get; set; }
        public Guid? categoryIntId { get; set; }
        public string proName { get; set; }
        public string prodCode { get; set; }
        public decimal prodPriceBuy { get; set; }
        public decimal prodPriceSales { get; set; }
        public DateTime proDate { get; set; }
        public int proStock { get; set; }
        public int proMinimalStock { get; set; }
        public bool proStatus { get; set; }

        public void SaveData(clsProduct clsProduct, Guid? updateKarIntId)
        {
            try
            {
                object valueCategories = new object();
                if (clsProduct.categoryIntId == null)
                {
                    valueCategories = DBNull.Value;
                }
                else
                {
                    valueCategories = clsProduct.categoryIntId;
                }
                Conexion.GDatos.BeginTransaction();

                Conexion.GDatos.Ejecutar("SP_IM_PRODUCT", clsProduct.prodIntId, valueCategories,
                                                          clsProduct.proName, clsProduct.prodCode,
                                                          clsProduct.prodPriceSales, clsProduct.proMinimalStock,
                                                          clsProduct.proStatus);


                Guid typKardex = Guid.Parse(new UtilsRespository().GetData("SP_GET_TYPE_KARDEX", "TYP_KAR_NAME", "TYP_KAR_ID", "Entrada").ToString());

                if (updateKarIntId != null)
                {

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

        public DataTable GetData(string procedure, Guid product, Guid typeKarde)
        {
            return Conexion.GDatos.TraerDataTable(procedure, product, typeKarde);
        }
    }
}