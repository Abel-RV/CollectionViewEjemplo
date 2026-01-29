using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewEjemplo
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLite.SQLiteAsyncConnection _connection;
    }
}
