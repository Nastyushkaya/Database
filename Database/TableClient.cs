using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TableClient : AbstractTable<Client>
    {
        protected override string GetAddSql()
        {
            return "INSERT INTO " + GetTableName() + "(room_id, data_from, data_to) VALUES (@room_id, @data_from, @data_to)";
        }

        protected override string GetTableName()
        {
            return "clients";
        }

        protected override void InitCommandValues(NpgsqlCommand command, Client data)  //insert data in table (set values to command parameters)
        {
            command.Parameters.AddWithValue("@room_id", data.RoomID);
            command.Parameters.AddWithValue("@data_from", data.DataFrom);
            command.Parameters.AddWithValue("@data_to", data.DataTo);
        }

        protected override Client ParseToModel(NpgsqlDataReader reader)  //insert data in table (set values to command parameters)
        {
            return new Client
            {
                ID = reader.GetInt32(0),
                RoomID = reader.GetInt32(1),
                DataFrom = reader.GetDateTime(2),
                DataTo = reader.GetDateTime(3), 
            };
        }
    }
}
