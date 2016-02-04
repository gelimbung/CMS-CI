using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class DeliverDao
    {
        public DbLibs.ClsDbase db;

        public int DeliverAdd(Model.Deliver dl)
        {
            int id = 0;
            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_DeliverAdd", new object[] {dl.room_id});
            if (dt.Rows.Count > 0)
            {
                id = Convert.ToInt16(dt.Rows[0]["id"].ToString());
            }
            return id;
        }

        public DataTable GetDeliver()
        {
            return this.db.execQuery("Sp_DeliverSel");
        }

        public DataTable GetDeliverReport(DateTime a,DateTime b)
        {
            return this.db.execQuery("Sp_DeliverSelRange", new object[] {a,b});
        }

        public DataTable GetDeliverProduct(int id)
        {
            return this.db.execQuery("Sp_DeliveryProductSel", new object[] { id });
        }

        public void DeliverProductAdd(int id,DeliverProduct orp)
        {
            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_ProductSelById", new Object[] { orp.product_id });
            if (Convert.ToInt16(dt.Rows[0]["qty_stock"].ToString()) >= orp.qty)
            {
                db.execUpdate("Sp_DeliverProductAdd", new object[] { id, orp.product_id, orp.qty });
                db.execUpdate("sp_ProductStockMinus", new object[] { orp.product_id, orp.qty });
            }
            else
            {
               
                throw (new MyException.OutOfStock(orp.product_id+": Out Of Stock"));
            }            
          
        }

        public void DeliveryDelete(int id)
        {
            DataTable dt = new DataTable();
            dt = db.execQuery("Sp_DeliveryProductSel", new object[] { id });
            foreach (DataRow record in dt.Rows)
            {
                int qty_stock = Convert.ToInt16(record["qty_stock"].ToString());
                int qty_order = Convert.ToInt16(record["qty"].ToString());
                String product_id = record["product_id"].ToString();
                
                db.execUpdate("Sp_ProductStockPlus", new object[] { product_id, qty_order });
     
              
            }
            db.execUpdate("Sp_DeliveryDelete", new object[] { id });
        }


        public Model.Deliver RecordDeliver(int id)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_DeliverySelById", new object[] { id });
                Model.Deliver rm = new Model.Deliver();
                if (dt.Rows.Count > 0)
                {
                    rm.delivery_id = Convert.ToInt16(dt.Rows[0]["delivery_id"].ToString());
                    rm.room_id = dt.Rows[0]["room_id"].ToString();
                    rm.delivery_date = dt.Rows[0]["delivery_date"].ToString();
                }

                return rm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    
    }


  
}
