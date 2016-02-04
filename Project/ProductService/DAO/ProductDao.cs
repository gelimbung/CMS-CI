using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class ProductDao
    {
        public DbLibs.ClsDbase db;

        public ProductDao()
        {

        }
        public void ProductAdd(Product inp,Uom uom)
        {
           
            db.execUpdate("Sp_ProductAdd",new object []{inp.product_id,uom.uom_code,inp.product_name,inp.qty_stock,inp.product_price});
        }

        public void ProductModify(Product inp, Uom uom,String key)
        {

            db.execUpdate("Sp_ProductModify", new object[] { key,inp.product_id, uom.uom_code, inp.product_name, inp.qty_stock, inp.product_price });
        }

        public DataTable GetProduct()
        {
           return this.db.execQuery("Sp_ProductSel");
        }

        public Product RecordProduct(String productId)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_ProductSelById", new object[] { productId });
                Model.Product prod = new Model.Product();
                if (dt.Rows.Count > 0)
                {
                    prod.product_id = dt.Rows[0]["product_id"].ToString();
                    prod.uom_code = dt.Rows[0]["uom_code"].ToString();
                    prod.product_name = dt.Rows[0]["product_name"].ToString();
                    //System.Console.Write(dt.Rows[0]["qtt_stock"].ToString());
                    prod.qty_stock = Convert.ToInt32(dt.Rows[0]["qty_stock"].ToString());
                    prod.product_price = Convert.ToInt32(dt.Rows[0]["product_price"].ToString());
                }

                return prod;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String ProductDelete(String id)
        {
            String msg = "Data successfully deleted";
            try
            {
                db.execUpdate("Sp_ProductDelete", new object[] { id });
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                msg = ex.Number.ToString();
                if (ex.Number == 2627)
                    msg = "Product id is duplicated";
                if (ex.Number == 547)
                    msg = "Data is being referenced";
            }
            return msg;
         
        }
    }
}
