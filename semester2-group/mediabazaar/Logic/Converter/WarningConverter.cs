using DataL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class WarningConverter : IConverter<Warnings, WarningDTO>
    {
        public WarningDTO Convert(Warnings source_object)
        {
            WarningDTO warningDTO = new WarningDTO
            {
                Reson = source_object.Reson,
            };

            return warningDTO;
        }

        public Warnings Convert(WarningDTO source_object)
        {
            Warnings Warning = new Warnings
            {
                Reson = source_object.Reson,
            };

            return Warning;
        }

        public WarningDTO[] Convert(List<Warnings> source_object)
        {
            List<WarningDTO> warnings = new List<WarningDTO>();
            foreach (Warnings item in CollectionsMarshal.AsSpan(source_object))
            {
                warnings.Add(Convert(item));
            }

            return warnings.ToArray();
        }

        public Warnings[] Convert(List<WarningDTO> source_object)
        {
            List<Warnings> warnings = new List<Warnings>();
            foreach (WarningDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                warnings.Add(Convert(item));
            }

            return warnings.ToArray();
        }
    }
}
