using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Service;
using ProductSvr.DAO;
using ProductSvr.Model;
using System.Data;
using System.ServiceModel;
namespace ProductSvr.Service
{
    [ServiceContract()]
    public interface IOrderService
    {
        [OperationContract]
        String OrderAdd(Model.Order or, List<Model.OrderProduct> orp);
        
        [OperationContract]
        String OrderModify(Model.Order or, List<Model.OrderProduct> orp);
        
        [OperationContract]
        DataTable GetOrder();
        
        [OperationContract]
        DataTable GetOrderReport(DateTime d_a, DateTime dz);
        
        [OperationContract]
        DataTable GetOrderProduct(int id);
        
        [OperationContract]
        String OrderDelete(int id);
        
        [OperationContract]
        Order OrderRecord(int id);
    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class OrderService : IOrderService
    {

        DbLibs.ClsDbase db = new DbLibs.ClsDbase();
        OrderDao dao = new OrderDao();
        public OrderService()
        {
            dao.db = db;
        }
        public string OrderAdd(Order or, List<OrderProduct> orp)
        {
            String msg = "Data sucessfully saved";
            db.beginTransaction();
            try
            {
                int id = dao.OrderAdd(or);
                foreach (OrderProduct prodMod in orp)
                {
                    dao.OrderProductAdd(id, prodMod);
                }
                db.commitTrans();
            }
            catch (Exception ex)
            {
                db.rollBackTrans();
                msg = ex.Message;
            }
            return msg;
        }

        public String OrderDelete(int id)
        {
            String msg = "Data sucessfully deleted";
            db.beginTransaction();
            try
            {
                dao.OrderDelete(id);
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




        public DataTable GetOrder()
        {
            return dao.GetOrder();
        }


        public Order OrderRecord(int id)
        {
            return dao.RecordOrder(id);
        }


        public DataTable GetOrderProduct(int id)
        {
            return dao.GetOrderProduct(id);
        }


        public string OrderModify(Order or, List<OrderProduct> orp)
        {
            String msg = "Data successfully saved";
            db.beginTransaction();
            try
            {
                int id = or.order_id;
                foreach (OrderProduct prodMod in orp)
                {
                    dao.OrderProductModify(id, prodMod);
                }
                db.commitTrans();
            }
            catch (MyException.OutOfStock ex)
            {
                msg = ex.Message;
                db.rollBackTrans();
            }
            catch (Exception ex)
            {
                db.rollBackTrans();
                throw ex;
            }
            return msg;
        }


        public DataTable GetOrderReport(DateTime d_a, DateTime dz)
        {
            return dao.GetOrderReport(d_a, dz);
        }
    }

}

