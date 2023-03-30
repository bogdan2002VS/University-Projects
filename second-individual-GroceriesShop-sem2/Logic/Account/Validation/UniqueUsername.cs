using DAL.Repository;
using Logic.Account.Service;
using System.ComponentModel.DataAnnotations;

namespace Logic.Account.Validation
{
    public class UniqueUsername : ValidationAttribute 
    {
        private IUserService service = new UserService(new UserRepository());

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                if (value != null)
                {
                    var username = value.ToString();
                    if (service.UsernameExists(username))
                    {

                        return new ValidationResult("Username already exists! Please try with another user");
                    }
                }
                return ValidationResult.Success;
            }
            catch (Exception)
            {

                return new ValidationResult("Sorry we cannot validate the input! Please try again later");
             }
           
        }

    }
}
