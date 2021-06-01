using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TableClassRoom : AbstractTable<ClassRoom>
    {
        protected override string GetAddSql()    //string sql
        {
            return "INSERT INTO " + GetTableName() + "(room_class, money) VALUES (@room_class, @money)";
        }

        protected override string GetTableName() //name of table 
        {
            return "class_room";
        }

        protected override void InitCommandValues(NpgsqlCommand command, ClassRoom data)  //set values to command parameters
        {
            command.Parameters.AddWithValue("@room_class", data.RoomClass);
            command.Parameters.AddWithValue("@money", data.Money);
        }

        protected override ClassRoom ParseToModel(NpgsqlDataReader reader)  //set values to command parameters
        {
            return new ClassRoom
            {
                ID = reader.GetInt32(0),
                RoomClass = reader.GetString(1),
                Money = reader.GetDouble(2),
            };
        }
    }
}
