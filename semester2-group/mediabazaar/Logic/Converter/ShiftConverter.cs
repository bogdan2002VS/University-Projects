using DataL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class ShiftConverter : IConverter<Shift, ShiftDTO>
    {
        public ShiftDTO Convert(Shift source_object)
        {
            ShiftDTO shiftDTO = new ShiftDTO
            {
                Id= source_object.Id,
                Start = source_object.Start,
                End = source_object.End,
                MaxSecurity = source_object.MaxSecurity,
                MaxCashier = source_object.MaxCashier,
                MaxStockManager = source_object.MaxStockManager,
                MaxDepoManager = source_object.MaxDepoManager,
                MaxEmployeeManager = source_object.MaxEmployeeManager,
                MaxHR = source_object.MaxHR,
                IsFull= source_object.IsFull,
                
            };

            return shiftDTO;
        }

        public Shift Convert(ShiftDTO source_object)
        {
            Shift shift = new Shift
            {
                Id = source_object.Id,
                Start = source_object.Start,
                End = source_object.End,
                MaxSecurity = source_object.MaxSecurity,
                MaxCashier = source_object.MaxCashier,
                MaxStockManager = source_object.MaxStockManager,
                MaxDepoManager = source_object.MaxDepoManager,
                MaxEmployeeManager = source_object.MaxEmployeeManager,
                MaxHR = source_object.MaxHR,
                IsFull= source_object.IsFull,
            };

            return shift;
        }

        public ShiftDTO[] Convert(List<Shift> source_object)
        {
            List<ShiftDTO> shiftDTOs= new List<ShiftDTO>();
            source_object.ForEach(s => shiftDTOs.Add(Convert(s)));

            return shiftDTOs.ToArray();
        }

        public Shift[] Convert(List<ShiftDTO> source_object)
        {
            List<Shift> shiftDTOs = new List<Shift>();
            source_object.ForEach(s => shiftDTOs.Add(Convert(s)));

            return shiftDTOs.ToArray();
        }
    }
}
