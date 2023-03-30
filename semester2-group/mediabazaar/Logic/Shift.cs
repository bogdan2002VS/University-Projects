using DataL.DTO;

namespace Logic
{
    public class Shift
    {
        private int id;
        private int maxCashier;
        private int maxSecurity;
        private int maxStockManager;
        private int maxDepoManager;
        private int maxEmployeeManager;
        private int maxHr;
        private DateTime start;
        private DateTime end;
        private bool isFull;

        public Shift(int id, DateTime start, DateTime end)
        {
            Id = id;
            Start = start;
            End = end;
        }

        public Shift(DateTime start, DateTime end)
        {
            Start = start;
            End = end;
        }

        public Shift(ShiftDTO shiftDTO)
        {
            Id = shiftDTO.Id;
            Start = shiftDTO.Start;
            End = shiftDTO.End;
            MaxCashier = (int)shiftDTO.MaxCashier;
            MaxSecurity = (int)shiftDTO.MaxSecurity;
            MaxStockManager = (int)shiftDTO.MaxStockManager;
            MaxDepoManager = (int)shiftDTO.MaxDepoManager;
            MaxEmployeeManager = (int)shiftDTO.MaxEmployeeManager;
            MaxHR = (int)shiftDTO.MaxHR;
            IsFull = shiftDTO.IsFull;
        }
        public Shift()
        {

        }

        public int Id { get; set; }
        public int MaxCashier { get; set; }
        public int MaxSecurity { get; set; }
        public int MaxStockManager { get; set; }
        public int MaxDepoManager { get; set; }
        public int MaxEmployeeManager { get; set; }
        public int MaxHR { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsFull { get; set; }

        public override string ToString()
        {
            return $"Day: {Start.DayOfWeek} | Start: {Start.TimeOfDay} | End: {End.TimeOfDay}";
        }
    }
}