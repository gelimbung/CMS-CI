using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class UomDao
    {
        public DbLibs.ClsDbase db;
        
       
        public void UomAdd(Uom inp)
        {
           
            db.execUpdate("Sp_UomAdd", new object []{inp.uom_code,inp.description});
        }

        public void UomModify(Uom inp,String code)
        {

            db.execUpdate("Sp_UomModify", new object[] { code,inp.uom_code, inp.description });
        }
        

        public String UomDelete(String code)
        {
            String msg = "Data successfully deleted";
            try
            {
                db.execUpdate("Sp_UomDelete", new object[] { code });
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

        public Model.Uom RecordUom(String id)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_UomSelById", new object[] { id });
                Model.Uom rm = new Model.Uom();
                if (dt.Rows.Count > 0)
                {
                    rm.uom_code = dt.Rows[0]["uom_code"].ToString();
                    rm.description = dt.Rows[0]["description"].ToString();
                }

                return rm;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetUom()
        {
            return this.db.execQuery("Sp_UomSel");
        }
    }
}
