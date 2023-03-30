using DataL.DTO;
using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Converter
{
    public class AddressConverter : IConverter<Address, AddressDTO>
    {
        public AddressDTO Convert(Address source_object)
        {
            AddressDTO addressDTO = new AddressDTO
            {
                StreetName = source_object?.StreetName,
                StreetNumber = source_object?.StreetNumber,
                City = source_object?.City,
                Country = source_object?.Country,
                Zip = source_object?.Zip
            };

            return addressDTO;
        }

        public Address Convert(AddressDTO source_object)
        {
            Address address = new Address
            {
                StreetName = source_object?.StreetName,
                StreetNumber = source_object?.StreetNumber,
                City = source_object?.City,
                Country = source_object?.Country,
                Zip = source_object?.Zip
            };

            return address;
        }

        public AddressDTO[] Convert(List<Address> source_object)
        {
            List<AddressDTO> addressDTOs = new List<AddressDTO>();
            foreach (Address item in CollectionsMarshal.AsSpan(source_object))
            {
                addressDTOs.Add(Convert(item));
            }

            return addressDTOs.ToArray();
        }

        public Address[] Convert(List<AddressDTO> source_object)
        {
            List<Address> addresses = new List<Address>();
            foreach (AddressDTO item in CollectionsMarshal.AsSpan(source_object))
            {
                addresses.Add(Convert(item));
            }

            return addresses.ToArray();
        }
    }
}
