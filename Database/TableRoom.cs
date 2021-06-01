using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TableRoom : AbstractTable<Room>, IRoomTable 
    {
        protected override string GetAddSql()    //string sql
        {
            return "INSERT INTO " + GetTableName() + "(number_room, room_class_id) VALUES (@number_room, @room_class_id)";
        }

        protected override string GetTableName()
        {
            return "rooms";
        }

        protected override void InitCommandValues(NpgsqlCommand command, Room data) //insert data in table (set values to command parameters)
        {
            command.Parameters.AddWithValue("@number_room", data.NumberRoom);
            command.Parameters.AddWithValue("@room_class_id", data.RoomClassID);
        }

        protected override Room ParseToModel(NpgsqlDataReader reader) //row from db turns into model (client, room or classroom) object
        {
            return new Room
            {
                ID = reader.GetInt32(0),
                NumberRoom = reader.GetString(1),
                RoomClassID = reader.GetInt32(2)
            };
        }
        public List<Room> GetAvailableRoomsByPeriodAndType(DateTime from, DateTime to, string type)
        {
            string sql = "SELECT * FROM rooms r, class_room cr WHERE cr.id=r.room_class_id and cr.room_class='" + type + "' AND NOT EXISTS " +
                    " (SELECT id FROM clients c WHERE c.room_id = r.id AND NOT " +
                        " (c.data_from > TO_DATE('" + to.Date.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD') OR c.data_to < TO_DATE('" + from.Date.ToString("yyyy-MM-dd") + "', 'YYYY-MM-DD')))";
            return ReadAllBySql(sql);   //return list of available rooms from db
        }
    }
}
