using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public enum ProductState
    {
        UNAVAILABLE,
        AVAILABLE
    }

    public enum EmployeeType
    {
        //employee
        security,
        cashier,
        stockmanager,
        depomamager,
        manageremployees,
        hr
    }
    public enum TicketStatus
    {
        requested,
        confirmed
    }

}
