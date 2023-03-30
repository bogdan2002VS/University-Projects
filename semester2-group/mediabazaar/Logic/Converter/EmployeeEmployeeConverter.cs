using DataL.DTO;
using Logic.EmployeeTypes;
using Logic.interfaces;
using Logic.Pool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class EmployeeEmployeeConverter : IConverter<Employee, EmployeeDTO>
    {
        public EmployeeDTO Convert(Employee source_object)
        {
            EmployeeDTO employeeDTO = new();

            switch (source_object.GetType().Name)
            {
                case "Security":
                    employeeDTO = ConverterPool.GetConverter<Security, EmployeeDTO>().Convert((Security)source_object);
                    break;
                case "Cashier":
                    employeeDTO = ConverterPool.GetConverter<Cashier, EmployeeDTO>().Convert((Cashier)source_object);
                    break;
                case "StockManager":
                    employeeDTO = ConverterPool.GetConverter<StockManager, EmployeeDTO>().Convert((StockManager)source_object);
                    break;
                case "DepoManager":
                    employeeDTO = ConverterPool.GetConverter<DepoManager, EmployeeDTO>().Convert((DepoManager)source_object);
                    break;
                case "ManagerEmployees":
                    employeeDTO = ConverterPool.GetConverter<ManagerEmployees, EmployeeDTO>().Convert((ManagerEmployees)source_object);
                    break;
                case "HR":
                    employeeDTO = ConverterPool.GetConverter<HR, EmployeeDTO>().Convert((HR)source_object);
                    break;
            }

            return employeeDTO;
        }

        public Employee Convert(EmployeeDTO source_object)
        {
            Employee employee = new();

            switch (source_object.EmployeeType)
            {
                case 0:
                    employee = ConverterPool.GetConverter<Security, EmployeeDTO>().Convert(source_object);
                    break;
                case 1:
                    employee = ConverterPool.GetConverter<Cashier, EmployeeDTO>().Convert(source_object);
                    break;
                case 2:
                    employee = ConverterPool.GetConverter<StockManager, EmployeeDTO>().Convert(source_object);
                    break;
                case 3:
                    employee = ConverterPool.GetConverter<DepoManager, EmployeeDTO>().Convert(source_object);
                    break;
                case 4:
                    employee = ConverterPool.GetConverter<ManagerEmployees, EmployeeDTO>().Convert(source_object);
                    break;
                case 5:
                    employee = ConverterPool.GetConverter<HR, EmployeeDTO>().Convert(source_object);
                    break;
            }

            return employee;
        }

        public EmployeeDTO[] Convert(List<Employee> source_object)
        {
            List<EmployeeDTO> employeeDTOs= new List<EmployeeDTO>();
            foreach (Employee item in CollectionsMarshal.AsSpan(source_object))
            {
                employeeDTOs.Add(Convert(item));
            }

            return employeeDTOs.ToArray();
        }

        public Employee[] Convert(List<EmployeeDTO> source_object)
        {
            List<Employee> employee = new List<Employee>();
            foreach (EmployeeDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                employee.Add(Convert(item));
            }

            return employee.ToArray();
        }
    }
}
