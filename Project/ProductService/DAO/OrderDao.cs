using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class OrderDao
    {
        public DbLibs.ClsDbase db;

        public int OrderAdd(Order or)
        {
            int id = 0;
            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_OrderAdd", new object[] { or.supplier_id });
            if (dt.Rows.Count > 0)
            {
                id = Convert.ToInt16(dt.Rows[0]["id"].ToString());
            }
            return id;
        }

        public void OrderModify(Order or)
        {
            db.execQuery("Sp_OrderModify", new object[] { or.order_id, or.supplier_id });
        }
        public void OrderProductAdd(int id, OrderProduct orp)
        {
            db.execUpdate("Sp_OrderProductAdd", new object[] { id, orp.product_id, orp.qty, orp.product_price });
            db.execUpdate("sp_ProductStockPlus", new object[] { orp.product_id, orp.qty });
        }

        public void OrderProductModify(int id, OrderProduct orp)
        {
            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_OrderProductSelById", new Object[] { id, orp.product_id });
            if (dt.Rows.Count > 0)
            {

                int qtt_product_master = Convert.ToInt32(dt.Rows[0]["qty"]);
                if (orp.qty != Convert.ToInt16(dt.Rows[0]["qty"]))
                {
                    if (orp.qty > Convert.ToInt16(dt.Rows[0]["qty"])) // berarti penambahan stok
                    {
                        int qtt_update = orp.qty - qtt_product_master;

                        db.execUpdate("sp_ProductStockPlus", new object[] { orp.product_id, qtt_update });
                        db.execUpdate("Sp_OrderProductModify", new object[] { id, orp.product_id, orp.qty, orp.product_price });
                    }
                    else //berarti pengurangan stok
                    {
                        DataTable dt_prod = new DataTable();
                        dt_prod = db.execQuery("Sp_ProductSelById", new Object[] { orp.product_id });
                        if (Convert.ToInt16(dt.Rows[0]["qty_stock"].ToString()) >= orp.qty)
                        {
                            db.execUpdate("sp_ProductStockMinus", new object[] { orp.product_id, orp.qty });
                        }
                        else
                        {
                            // jika stok pada data produk tidak mencukupi maka tidak proses tidak dilakukan
                            throw (new MyException.OutOfStock(orp.product_id + ": Out Of Stock"));
                        }

                    }
                }
            }
            else
            {
                db.execUpdate("Sp_OrderProductAdd", new object[] { id, orp.product_id, orp.qty, orp.product_price });
                db.execUpdate("sp_ProductStockPlus", new object[] { orp.product_id, orp.qty });
            }
        }


        public DataTable GetOrder()
        {
            return this.db.execQuery("Sp_OrderSel");
        }

        public DataTable GetOrderProduct(int id)
        {
            return this.db.execQuery("Sp_OrderProductSel", new object[] { id });
        }

        public void OrderDelete(int id)
        {

            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_OrderProductSel", new object[] { id });
            foreach (DataRow record in dt.Rows)
            {
                int qty_stock = Convert.ToInt16(record["qty_stock"].ToString());
                int qty_order = Convert.ToInt16(record["qty"].ToString());
                String product_id = record["product_id"].ToString();
                if (qty_stock >= qty_order)
                {
                    db.execUpdate("sp_ProductStockMinus", new object[] { product_id, qty_order });
                }
                else
                {

                    throw (new MyException.OutOfStock(product_id + ": Out Of Stock"));
                }
            }
            db.execUpdate("Sp_OrderDelete", new object[] { id });

        }

        public Model.Order RecordOrder(int id)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_OrderSelById", new object[] { id });
                Model.Order rm = new Model.Order();
                if (dt.Rows.Count > 0)
                {
                    rm.order_id = Convert.ToInt16(dt.Rows[0]["order_id"].ToString());
                    rm.supplier_id = Convert.ToInt16(dt.Rows[0]["supplier_id"].ToString());
                    rm.order_date = dt.Rows[0]["order_date"].ToString();
                }

                return rm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetOrderReport(DateTime d_a,DateTime d_z)
        {
            return this.db.execQuery("Sp_OrderSelRange", new object[]{ d_a,d_z});
        }

    }



}
