using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace Feedbacks.CollectorInterface.DatabaseRepository
{

    public interface IDatabaseHandler
    {
        DbConnection CreateConnection();

        DbCommand CreateCommand(string commandText, CommandType commandType);

        DbParameter CreateParameter(IDbCommand command);
    }
}
