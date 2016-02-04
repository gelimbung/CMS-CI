using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class SupplierDao
    {
        public DbLibs.ClsDbase db;

        public void SupplierAdd(Supplier inp)
        {

            this.db.execUpdate("Sp_SupplierAdd", new Object[] {inp.supplier_name,inp.address,inp.email,inp.email});
        }

        public DataTable GetSupplier()
        {
            return this.db.execQuery("Sp_SupplierSel");
        }

        public Model.Supplier RecordSupplier(int id)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_SupplierSelById", new object[] { id });
                Model.Supplier supp = new Model.Supplier();
                if (dt.Rows.Count > 0)
                {
                    supp.supplier_id = Convert.ToInt16(dt.Rows[0]["supplier_id"].ToString());
                    supp.supplier_name = dt.Rows[0]["supplier_name"].ToString();
                    supp.address = dt.Rows[0]["address"].ToString();
                    supp.email = dt.Rows[0]["email"].ToString();
                    supp.phone = dt.Rows[0]["phone"].ToString();
                }

                return supp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SupplierModify(Supplier inp)
        {

            this.db.execUpdate("Sp_SupplierModify", new Object[] { inp.supplier_id,inp.supplier_name, inp.address, inp.email, inp.email });
        }

        public String SupplierDelete(int id)
        {
            String msg = "Data successfully deleted";
            try
            {
                db.execUpdate("Sp_SupplierDelete", new object[] { id });
            }catch (System.Data.SqlClient.SqlException ex){
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
