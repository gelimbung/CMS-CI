using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;
using ProductSvr.DAO;


namespace ProductSvr.Service
{
    [ServiceContract()]
    public interface IRoomService
    {
        [OperationContract]
        String RoomAdd(Model.Room rm);

        [OperationContract]
        String RoomModify(Model.Room rm, String key);

        [OperationContract]
        String RoomDelete(String room_id);

        [OperationContract]
        DataTable GetRoom();

        [OperationContract]
        Model.Room RecordRoom(String id);

    }

    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class RoomService : IRoomService
    {
        private DbLibs.ClsDbase db;
        private RoomDao roomSr;
        string conn = "uid=sa;pwd=;database=wilayah2;server=.";
        public RoomService()
        {
            this.db = new DbLibs.ClsDbase(conn);
            roomSr = new DAO.RoomDao();
            roomSr.db = this.db;
        }

        public String RoomAdd(Model.Room rm)
        {
            String msg = "";
            this.db.beginTransaction();
            try
            {
                roomSr.RoomAdd(rm);
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

        public DataTable GetRoom()
        {
            return roomSr.GetRoom();
        }


        public Model.Room RecordRoom(String id)
        {
            return roomSr.RecordRoom(id);

        }


        public String RoomModify(Model.Room rm, String key)
        {
            String msg = "";
            this.db.beginTransaction();
            try
            {
                roomSr.RoomModify(rm, key);
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


        public String RoomDelete(String room_id)
        {
            roomSr.RoomDelete(room_id);
            return String.Empty;
        }
    }
}
