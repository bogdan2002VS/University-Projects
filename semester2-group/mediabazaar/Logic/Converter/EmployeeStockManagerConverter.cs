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
    public class EmployeeStockManagerConverter : IConverter<StockManager, EmployeeDTO>
    {
        public EmployeeDTO Convert(StockManager source_object)
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
                EmployeeType = 2,
                IsActive = source_object.IsActive,
                Username = source_object.EmployeeCredentials.Username
            };

            return employeeDTO;
        }

        public StockManager Convert(EmployeeDTO source_object)
        {
            Address address = ConverterPool.GetConverter<Address, AddressDTO>().Convert(source_object.Address);

            StockManager stockManager = new StockManager(source_object.Id, source_object.FirstName, source_object.LastName,
                source_object.Email, address, source_object.DateOfBirth,
                source_object.PhoneNumber, source_object.Bsn, source_object.IsActive);

            return stockManager;
        }

        public EmployeeDTO[] Convert(List<StockManager> source_object)
        {
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (StockManager item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public StockManager[] Convert(List<EmployeeDTO> source_object)
        {
            List<StockManager> stockManager = new List<StockManager>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                stockManager.Add(Convert(item));
            }

            return stockManager.ToArray();
        }
    }
}
