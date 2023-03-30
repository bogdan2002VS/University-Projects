using DataL.DTO;
using Logic.ClassManagers;
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
    public class EmployeeHRConverter : IConverter<HR, EmployeeDTO>
    {
        public EmployeeDTO Convert(HR source_object)
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
                EmployeeType = 5,
                IsActive = source_object.IsActive,
                Username = source_object.EmployeeCredentials.Username
            };

            return employeeDTO;
        }

        public HR Convert(EmployeeDTO source_object)
        {
            Address address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.Address);

            HR hr = new HR(source_object.Id, source_object.FirstName, source_object.LastName,
                source_object.Email, address, source_object.DateOfBirth,
                source_object.PhoneNumber, source_object.Bsn, source_object.IsActive);

            return hr;
        }

        public EmployeeDTO[] Convert(List<HR> source_object)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (HR item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public HR[] Convert(List<EmployeeDTO> source_object)
        {
            List<HR> hr = new List<HR>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                hr.Add(Convert(item));
            }

            return hr.ToArray();
        }
    }
}
