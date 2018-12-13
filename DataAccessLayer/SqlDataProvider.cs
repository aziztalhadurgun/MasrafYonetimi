using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    //Sql Bağlantı katmanı 
    //Referans olarak ekleme yapmayı unutma
    public class SqlDataProvider
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }

        public SqlDataProvider(string connStr)
        {
            this.Connection = new SqlConnection(connStr);
            this.Command = this.Connection.CreateCommand();
        }

        public DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            this.Command.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(this.Command); //adapter command ister
            //adapter connection kendisi açar kapatır birdaha bizim açmamıza gerek duymaz
            adapter.Fill(dt); //bütün datayı çeker ve datatable a atar.

            return dt;
        }
        public object GetSingleData(string query)
        {
            //kodlanmadığına dair hata fırlatır.
            //throw new NotImplementedException();

            object result = null;
            this.Command.CommandText = query;

            this.Connection.Open();

            result = this.Command.ExecuteScalar();

            this.Connection.Close(); 
            return result;

        }

        public int RunQuery(string sorgu)
        {
            int result = 0;

            this.Command.CommandText = sorgu;
            this.Connection.Open();
            result = this.Command.ExecuteNonQuery();
            this.Connection.Close();

            return result;
        }

        public int spFunk()
        {
            int result = 0;

            this.Connection.Open();
            result = this.Command.ExecuteNonQuery();
            this.Connection.Close();

            return result;
        }
    }
}
