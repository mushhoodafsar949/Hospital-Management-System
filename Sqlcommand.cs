using System;
using System.Data;
using System.Data.SqlClient;

namespace Yahoo
{
    internal class Sqlcommand
    {
        public CommandType CommandType { get; internal set; }
        public object Parameters { get; internal set; }

        public static implicit operator Sqlcommand(SqlCommand v)
        {
            throw new NotImplementedException();
        }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}