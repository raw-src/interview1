using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_system_api.Interfaces
{
    public interface IDatabaseHandler
    {
        ICollection<T> FindAll<T>(object item_find);
        T Find<T>(object item_find);
        int Insert<T>(T insert_item);
        bool Update<T>(T update_item);
        bool Delete<T>(int id);
    }
}
