using FluentValidation;
using Logic.EmployeeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Logic.Validation
{
    public class EmployeeValidation : AbstractValidator<Employee>
    {
        public EmployeeValidation()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty()
                .Matches(@"^[A-Z][a-zA-Z]*$")
                .WithMessage("Invalid First name ex: Michael");

            RuleFor(c => c.LastName)
                .NotEmpty()
                .Matches(@"^[A-Z][a-zA-Z]*$")
                .WithMessage("Invalid Last name ex: Blob");
            
            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(c => c.PersonAddress).SetValidator(new AddressValidation());

            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Now));

            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .Matches(@"^[0-9]*")
                .WithMessage("Invalid Phone number");

            RuleFor(x => x.Bsn.ToString())
                .NotEmpty()
                .Matches(@"^[0-9]*")
                .WithMessage("Invalid BSN");
        }
    }
}
