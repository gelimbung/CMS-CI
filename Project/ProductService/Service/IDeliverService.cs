using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Service;
using ProductSvr.DAO;
using ProductSvr.Model;
using System.ServiceModel;
namespace ProductSvr.Service
{
    [ServiceContract()]
    public interface IDeliverService
    {
        [OperationContract]
        String DeliverAdd(Model.Deliver dl, List<Model.DeliverProduct> dlp);
        
        [OperationContract]
        DataTable GetDeliver();

        [OperationContract]
        DataTable GetDeliverReport(DateTime a, DateTime b);

        [OperationContract]
        DataTable GetDeliverProduct(int id);

        [OperationContract]
        String DeliveryDelete(int id);

        [OperationContract]
        Deliver DeliveryRecord(int id);
    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DeliverService : IDeliverService
    {
        DbLibs.ClsDbase db = new DbLibs.ClsDbase();
        DAO.DeliverDao dao = new DAO.DeliverDao();

        public DeliverService()
        {
            dao.db = this.db;
        }

        public string DeliverAdd(Deliver dl, List<DeliverProduct> dlp)
        {
            String msg = "";
            db.beginTransaction();
            try
            {
                int id = dao.DeliverAdd(dl);
                foreach (DeliverProduct prodMod in dlp)
                {
                    dao.DeliverProductAdd(id, prodMod);
                }
                msg = "Data Successfully Saved";
                db.commitTrans();
            }
            catch (MyException.OutOfStock ex)
            {
                msg = "Transaction failed" + "\n" + ex.Message;
                db.rollBackTrans();
                //throw ex;
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
                db.rollBackTrans();

                //throw ex;
            }

            return msg;
        }


        public DataTable GetDeliver()
        {
            return dao.GetDeliver();
        }


        public string DeliveryDelete(int id)
        {
            String msg = "Data sucessfully deleted";
            db.beginTransaction();
            try
            {
                dao.DeliveryDelete(id);
                db.commitTrans();
            }
            catch (MyException.OutOfStock ex)
            {
                msg = "Transaction failed" + "\n" + ex.Message;
                db.rollBackTrans();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                db.rollBackTrans();
            }
            return msg;
        }


        public Deliver DeliveryRecord(int id)
        {
            return dao.RecordDeliver(id);
        }


        public DataTable GetDeliverProduct(int id)
        {
            return dao.GetDeliverProduct(id);
        }


        public DataTable GetDeliverReport(DateTime a, DateTime b)
        {
            return dao.GetDeliverReport(a, b);
        }
    }

}

