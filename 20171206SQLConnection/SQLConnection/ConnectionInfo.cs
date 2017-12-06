using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SQLConnection
{
    public static class ConnectionInfo
    {
        private static string _connectionString = "Server=.;Database=NORTHWND;Trusted_Connection=True";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }
    }
}