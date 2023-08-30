using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SAARS.requests
{
    public class DBConnector
    {
        public string ConnectionString;
        public DBConnector() {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "qwertycode.database.windows.net";
            builder.UserID = "noahclark556";
            builder.Password = "GO@@rmy224";
            builder.InitialCatalog = "saars";
            ConnectionString = builder.ConnectionString;

        }

    }
}
