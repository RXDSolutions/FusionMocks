using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Sophis.DataAccess
{
    public static class DBContext
    {
        public static OracleConnection Connection { get; private set; }

        public static void SetConnection(OracleConnection connection)
        {
            Connection = connection;
        }
    }
}
