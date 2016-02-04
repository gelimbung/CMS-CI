using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProductSvr.DAO;
using System.ServiceModel;

namespace ProductSvr.Service
{
    [ServiceContract()]
    public interface ISupplierService
    {
        [OperationContract]
        String SupplierAdd(Model.Supplier inp);
        [OperationContract]
        String SupplierModify(Model.Supplier inp);
        [OperationContract]
        String SupplierDelete(int id);
        [OperationContract]
        DataTable GetSupplier();
        [OperationContract]
        Model.Supplier RecordSupplier(int supplier_id);

    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class SupplierService : ISupplierService
    {
        private DbLibs.ClsDbase db = new DbLibs.ClsDbase();
        private SupplierDao dao = new SupplierDao();


        public SupplierService()
        {
            this.dao.db = db;
        }

        public string SupplierAdd(Model.Supplier inp)
        {
            String msg = "";
            this.db.beginTransaction();
            try
            {
                this.dao.SupplierAdd(inp);
                msg = "Data succesfully saved";
                this.db.commitTrans();
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
                this.db.rollBackTrans();
                throw ex;
            }

            return msg;

        }

        public DataTable GetSupplier()
        {

            return this.dao.GetSupplier();

        }


        public Model.Supplier RecordSupplier(int supplier_id)
        {
            return dao.RecordSupplier(supplier_id);
        }


        public string SupplierModify(Model.Supplier inp)
        {
            String msg = "";
            this.db.beginTransaction();
            try
            {
                dao.SupplierModify(inp);
                msg = "Data succesfully saved";
                this.db.commitTrans();
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
                this.db.rollBackTrans();
                throw ex;
            }

            return msg;

        }


        public string SupplierDelete(int id)
        {
            return dao.SupplierDelete(id);
        }
    }
}
