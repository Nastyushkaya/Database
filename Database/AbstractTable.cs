using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public abstract class AbstractTable<T> : ITable<T> where T: class
    {
        private static NpgsqlConnection connection = new NpgsqlConnection(); 
        public AbstractTable()
        {
            connection.ConnectionString = @" Host = localhost; Port = 5432; Database = Database; Username = postgres; Password = postgres ";
            //database connection string 
        }

        public bool Add(T data)
        {
            try
            {
                string sql = GetAddSql();     //insert
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                InitCommandValues(command, data);  //insert data in table (set values to command parameters)
                connection.Open();
                command.ExecuteNonQuery();  //do our command (insert)
                connection.Close();
                return true;
            }
            catch (SqlException e) {
                return false;
            }    
        }

        public bool Delete(int data)
        {
            try
            {
                string sql = "DELETE FROM " + GetTableName() + " WHERE id = " + data; //delete
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();   //do our command (delete)
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public T Read(int data)
        {
            try
            {
                string sql = "SELECT * FROM " + GetTableName() + " WHERE id = " + data; //select
                return ReadAllBySql(sql).FirstOrDefault();     //return one element (using its id)
            }
            catch (SqlException e)
            {
                return null;
            }
        }

        public List<T> ReadAll()
        {
            string sql = "SELECT * FROM " + GetTableName();
            return ReadAllBySql(sql); //return all rows from db
        }

        protected List<T> ReadAllBySql(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql, connection);
            List<T> data = new List<T>();
            connection.Open();
            var reader = command.ExecuteReader();   //read rows and go through them
            while (reader.Read())                   //while we have rows
            {
                data.Add(ParseToModel(reader));     //row from db turns into model (client, room or classroom) object
            }
            reader.Close();
            connection.Close();
            return data;                            //return list of models from db
        }

        protected abstract string GetTableName();   
        protected abstract T ParseToModel(NpgsqlDataReader reader);  //row from db turns into model (client, room or classroom) object
        protected abstract string GetAddSql();
        protected abstract void InitCommandValues(NpgsqlCommand command, T data);  //insert data in table (set values to command parameters)
    }
}
