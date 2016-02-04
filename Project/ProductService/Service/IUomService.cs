using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.DAO;
using System.Data;
using System.Security;
using System.ServiceModel;
namespace ProductSvr.Service
{
    [ServiceContract()]
    public interface IUomService
    {
        [OperationContract]
        String UomAdd(Model.Uom uom);
        [OperationContract]
        String UomModify(Model.Uom uom, String uom_code);
        [OperationContract]
        String UomDelete(String uom_code);
        [OperationContract]
        System.Data.DataTable GetUom();
        [OperationContract]
        Model.Uom RecordUom(String uom_code);

    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class UomService : IUomService
    {
        DbLibs.ClsDbase db = new DbLibs.ClsDbase();
        UomDao dao = new UomDao();

        public UomService()
        {
            dao.db = this.db;
        }
        public String UomAdd(Model.Uom uom)
        {
            String msg = "";
            db.beginTransaction();
            try
            {
                dao.UomAdd(uom);
                db.commitTrans();
                msg = "Data successfuly updated";
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                msg = ex.Number.ToString();
                if (ex.Number == 2627)
                    msg = "Duplicate Product Id";

                db.rollBackTrans();
            }
            catch (Exception ex)
            {
                // throw ex;

                msg = "System Error: " + ex.Message;
                db.rollBackTrans();
            }
            return msg;

        }

        public System.Data.DataTable GetUom()
        {
            return dao.GetUom();
        }



        public String UomModify(Model.Uom uom, String uom_code)
        {
            String msg = "";
            db.beginTransaction();
            try
            {
                dao.UomModify(uom, uom_code);
                db.commitTrans();
                msg = "Data successfuly updated";
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                msg = ex.Number + "-" + ex.Message;
                if (ex.Number == 2627)
                    msg = "Duplicate Product Id";
                if (ex.Number == 547)
                    msg = "Data Is Bing referenced";
                db.rollBackTrans();
            }
            catch (Exception ex)
            {
                //throw ex;
                db.rollBackTrans();
            }
            return msg;
        }


        public String UomDelete(String uom_code)
        {


            return dao.UomDelete(uom_code);
        }


        public Model.Uom RecordUom(String uom_code)
        {
            return dao.RecordUom(uom_code);
        }
    }

}
