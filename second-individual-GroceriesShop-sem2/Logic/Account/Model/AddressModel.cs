using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Logic.Account.Model
{
    public class AddressModel
    {
        [Required, DataType(DataType.Text, ErrorMessage = "Please enter  a valid street name")]
        public string StreeName { get; set; }

        [Required, DataType(DataType.Text, ErrorMessage = "Please enter a numeric House Number")]
        public int HouseNo { get; set; }

        [Required, DataType(DataType.Text, ErrorMessage = "Please enter  a valid city name")]
        public string City { get; set; }
        [Required, RegularExpression("(^[1-9]{1}[0-9]{3} ?[A-Z]{2}$)", ErrorMessage = "Please enter  a valid zipcode, like 1233AA")]
        public string ZipCode { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj != null && obj is AddressModel)
            {
                var a = (AddressModel)obj;
                return a.StreeName == this.StreeName && a.HouseNo == this.HouseNo  && a.City == this.City && a.ZipCode == this.ZipCode;
            }
            return false;
        }

        public override string? ToString()
        {
            return $"{this.StreeName} {this.HouseNo.ToString()}, {this.ZipCode}";
        }

    }
}
