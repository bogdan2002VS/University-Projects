using DataL.DTO;
using Logic.EmployeeTypes;
using Logic.Pool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class EmployeeCashierConverter : IConverter<Cashier, EmployeeDTO>
    {
        public EmployeeDTO Convert(Cashier source_object)
        {
            EmployeeDTO employeeDTO = new EmployeeDTO
            {
                Id = source_object.Id,
                FirstName = source_object.FirstName,
                LastName = source_object.LastName,
                Email = source_object.Email,
                Address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.PersonAddress),
                DateOfBirth = source_object.DateOfBirth,
                PhoneNumber = source_object.PhoneNumber,
                Bsn = source_object.Bsn,
                EmployeeType = 1,
                IsActive = source_object.IsActive,
                Username = source_object.EmployeeCredentials.Username
            };

            return employeeDTO;
        }

        public Cashier Convert(EmployeeDTO source_object)
        {
            Address address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.Address);

            Cashier cashier = new Cashier(source_object.Id, source_object.FirstName, source_object.LastName,
                source_object.Email, address, source_object.DateOfBirth,
                source_object.PhoneNumber, source_object.Bsn, source_object.IsActive);

            return cashier;
        }

        public EmployeeDTO[] Convert(List<Cashier> source_object)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (Cashier item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public Cashier[] Convert(List<EmployeeDTO> source_object)
        {
            List<Cashier> cashier = new List<Cashier>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                cashier.Add(Convert(item));
            }

            return cashier.ToArray();
        }
    }
}
