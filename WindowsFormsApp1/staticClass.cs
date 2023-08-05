using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    internal class staticClass
    {
        internal protected OleDbDataAdapter bridge;
        internal protected OleDbConnection con;
        internal protected OleDbCommand cmd;

       internal static String connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FitnessTrackerDB.accdb;Jet OLEDB:Database Password=project;";
    }
}
