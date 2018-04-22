using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQLite_DataBase
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
