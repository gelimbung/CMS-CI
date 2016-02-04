using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProductSvr.Model;
using System.Data;
using DbLibs;
namespace ProductSvr.DAO
{
    public class RoomDao
    {
        public DbLibs.ClsDbase db;
        
       
        public void RoomAdd(Room rm)
        {
           
            db.execUpdate("Sp_RoomAdd", new object []{rm.room_id,rm.room_name});
        }

        public void RoomModify(Room rm,String key)
        {

            db.execUpdate("Sp_RoomModify", new object[] { key,rm.room_id, rm.room_name });
        }

        public void RoomDelete(String id)
        {
            db.execUpdate("Sp_RoomDelete", new object[] {id});
        }

        public DataTable GetRoom()
        {
            return this.db.execQuery("Sp_RoomSel");
        }

        public Model.Room RecordRoom(String id)
        {
            try
            {
                DataTable dt;
                dt = new DataTable();
                dt = this.db.execQuery("Sp_RoomSelById", new object[] { id });
                Model.Room rm = new Model.Room();
                if (dt.Rows.Count > 0)
                {
                    rm.room_id = dt.Rows[0]["room_id"].ToString();
                    rm.room_name = dt.Rows[0]["room_name"].ToString();
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
