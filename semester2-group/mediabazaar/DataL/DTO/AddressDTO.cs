using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataL.DTO
{
    public class AddressDTO
    {
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? Zip { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }

        public AddressDTO(string streetName, string streetNumber, string zip, string city, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            Zip = zip;
            City = city;
            Country = country;
        }

        public AddressDTO()
        {

        }
    }
}
