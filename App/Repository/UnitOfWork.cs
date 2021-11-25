using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository
{
    class UnitOfWork
    {
        static protected MySQLite db;
        public UnitOfWork()
        {
            db = new MySQLite();
            db.Connect();
        }

        public int GetLastId()
        {
            var result = db.ExecuteScalar("select last_insert_rowid()");
            Int64 lastRowId = Convert.ToInt64(result);
            return (int)lastRowId;
        }
    }
}
