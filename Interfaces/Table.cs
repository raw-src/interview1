using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_system_api.Interfaces
{
    public class Table<T>
    {
        protected IDatabaseHandler DatabaseHandler { get; set; }

        public Table(IDatabaseHandler databaseHandler)
        {
            DatabaseHandler = databaseHandler;
        }

        public int Insert(T insert_item)
        {
            return DatabaseHandler.Insert<T>(insert_item);
        }
        public bool Update(T insert_item)
        {
            return DatabaseHandler.Update<T>(insert_item);
        }
        public T Find(object insert_item)
        {
            return DatabaseHandler.Find<T>(insert_item);
        }
        public ICollection<T> FindAll(object insert_item)
        {
            return DatabaseHandler.FindAll<T>(insert_item);
        }
        public bool Delete(int id)
        {
            return DatabaseHandler.Delete<T>(id);
        }
    }
}
