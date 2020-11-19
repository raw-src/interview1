using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticket_system_api.Models
{
    public enum TicketState
    {
        NotStarted = 1,
        WorkingOn = 2,
        Testing = 3,
        Done = 4
    }
}
