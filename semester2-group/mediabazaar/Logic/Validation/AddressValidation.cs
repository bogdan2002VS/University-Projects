using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Validation
{
    public class AddressValidation : AbstractValidator<Address>
    {
        public AddressValidation()
        {
            RuleFor(x => x.StreetNumber)
                .NotEmpty()
                .Matches(@"^[0-9]*")
                .WithMessage("Invalid Street number ex: 1");

            RuleFor(x => x.StreetName)
                .NotEmpty()
                .Matches(@"^[A-Z][a-zA-Z]*$")
                .WithMessage("Invalid Street name");

            RuleFor(x => x.Zip)
                .NotEmpty()
                .Matches(@"^[1-9][0-9]{3} ?(?!sa|sd|ss)[a-z]{2}$")
                .WithMessage("Invalid postal code");

            RuleFor(x => x.Country)
                .NotEmpty()
                .Matches(@"^[A-Z][a-zA-Z]*$")
                .WithMessage("Invalid country");

            RuleFor(x => x.City)
                .NotEmpty()
                .Matches(@"^[A-Z][a-zA-Z]*$")
                .WithMessage("Invalid City");
        }
    }
}
