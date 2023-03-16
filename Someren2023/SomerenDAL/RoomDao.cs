using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT RoomID, RoomNumber, capacity, inhabitant  FROM [Room]";  
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)  
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                //this gets the values 
                int id = (int)dr["RoomID"];
                int number = (int)dr["RoomNumber"];
                int capacity = (int)dr["capacity"];
                bool type = (bool)dr["inhabitant"];
                //assignes values to new instance
                Room room = new Room(id, number, capacity, type);
                //adds to the rooms list 
                rooms.Add(room);
            }
            return rooms;
        }
    }
}