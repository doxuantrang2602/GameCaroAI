using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaroAI.Classes
{
    internal class DataProcesserTrang
    {
        string connectStr = "Data Source=DESKTOP-SVVHT2F\\SQLEXPRESS;Initial Catalog=GameCaroAI;Integrated Security=True";
        SqlConnection sqlConn = null;
        public void OpenConnect()
        {
            sqlConn = new SqlConnection(connectStr);
            if (sqlConn.State != ConnectionState.Open)
            {
                sqlConn.Open();
            }
        }
        public void CloseConnect()
        {
            if (sqlConn.State != ConnectionState.Closed)
                sqlConn.Close();
            sqlConn.Dispose();
        }
        
    }
}
