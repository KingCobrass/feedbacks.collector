using Feedbacks.CollectorInterface.DatabaseRepository;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Feedbacks.Collector.DataAccess.DAL
{
    public class PostgresDataAccess : IDatabaseHandler
    {
        private string ConnectionString { get; set; }

        public PostgresDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public DbConnection CreateConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }

        public DbCommand CreateCommand(string commandText, CommandType commandType)
        {
            return new NpgsqlCommand
            {
                CommandText = commandText,
                CommandType = commandType
            };
        }
        public DbParameter CreateParameter(IDbCommand command)
        {
            NpgsqlCommand SQLcommand = (NpgsqlCommand)command;
            return SQLcommand.CreateParameter();
        }
    }
}
