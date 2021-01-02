using System;
using System.Collections.Generic;
using System.Text;

namespace Feedbacks.CollectorInterface.DatabaseRepository
{
    public class DatabaseConenctionProviders
    {
        public const string SQLServerProvider = "system.data.sqlclient";
        public const string PostgreSQLProvider = "npgsql";
        public const string MySQLProvider = "mysql.data.mysqlclient";
    }
}
