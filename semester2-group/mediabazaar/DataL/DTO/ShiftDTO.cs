using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.DTO
{
    public class ShiftDTO
    {
        public ShiftDTO(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }

        public ShiftDTO(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public ShiftDTO()
        {

        }
        public int Id { get; set; }
        public int MaxSecurity { get; set; }
        public int MaxCashier { get; set; }
        public int MaxStockManager { get; set; }
        public int MaxDepoManager { get; set; }
        public int MaxEmployeeManager { get; set; }
        public int MaxHR { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsFull { get; set; } = false;
    }
}
