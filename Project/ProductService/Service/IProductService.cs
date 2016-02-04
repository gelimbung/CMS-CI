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
    public interface IProductService
    {
        [OperationContract]
        String ProductAdd(Model.Product rm, Model.Uom uom);
        [OperationContract]
        String ProductModify(Model.Product rm, Model.Uom uom, String key);
        [OperationContract]
        DataTable GetProduct();
        [OperationContract]
        Model.Product recordProduct(String prodId);
        [OperationContract]
        String ProductDelete(String id);
    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class ProductService : IProductService
    {
        private DbLibs.ClsDbase db = new DbLibs.ClsDbase();
        private ProductDao dao = new ProductDao();


        public ProductService()
        {
            dao.db = this.db;
        }

        public string ProductAdd(Model.Product rm, Model.Uom uom)
        {
            String msg = "";
            this.db.beginTransaction();
            try
            {
                dao.ProductAdd(rm, uom);
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

        public DataTable GetProduct()
        {
            return dao.GetProduct();
        }


        public Model.Product recordProduct(String prodId)
        {
            return dao.RecordProduct(prodId);
        }


        public string ProductModify(Model.Product rm, Model.Uom uom, String key)
        {
            String msg = "";
            db.beginTransaction();
            try
            {
                dao.ProductModify(rm, uom, key);
                db.commitTrans();
                msg = "Data succesfully updated";
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





        public string ProductDelete(string id)
        {
            dao.ProductDelete(id);
            return dao.ProductDelete(id);
        }
    }
}
