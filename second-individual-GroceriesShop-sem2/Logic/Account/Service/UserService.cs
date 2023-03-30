using System.Data;
using DAL.DTO;
using DAL.Repository;
using Logic.Account.Util;
using Logic.Model;

namespace Logic.Account.Service
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }


        public int RegisterCustomer(UserModel user)
        {
            try
            {
                string salt = HashingSalting.CreateSalt(8);

                string passwordHash = createPasswordHash(user, salt);
                UserDTO userDTO = new UserDTO()
                {
                    Name = user.Name,
                    Username = user.Username,
                    Password = passwordHash,
                    Email = user.Email,
                    Role = "Customer",
                    Salt = salt
                };
                return userRepository.CreateUser(userDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not create customer user", ex);
            }
        }

        public int RegisterEmployee(UserModel user)
        {
            try
            {
                string salt = HashingSalting.CreateSalt(8);
                string passwordHash = createPasswordHash(user, salt);
                UserDTO userDTO = new UserDTO()
                {
                    Name = user.Name,
                    Username = user.Username,
                    Password = passwordHash,
                    Email = user.Email,
                    Role = "Staff",
                    Salt = salt
                };
                return userRepository.CreateUser(userDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not create employee user", ex);
            }
        }

        public UserProfileModel ReadUserProfile(int userId)
        {
            try
            {
                UserDTO userDTO = userRepository.ReadUserById(userId);

                return new UserProfileModel(userDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not read userProfile", ex);
            }

        }

        public void DeleteUser(int userId)
        {
            try
            {
                userRepository.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not delete user", ex);
            }
        }

        private bool CheckPasswordEquality(string salt, string passToCheck, string passFromDB)
        {
            try
            {
                string hashedCheckPassword = HashingSalting.GenerateSHA256Hash(passToCheck, salt);

                if (hashedCheckPassword.Equals(passFromDB))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not check password", ex);
            }

        }
        public UserModel Login(UserModel userModel) 
        { 
            try
            {  // need to read by username because we don't have the salt to check the password hash
                UserDTO userDTO = userRepository.ReadUserByUsername(userModel.Username);
                bool isPasswordOk = CheckPasswordEquality(userDTO.Salt, userModel.Password, userDTO.Password)
                    && userDTO.Username == userModel.Username;

                if (isPasswordOk)
                {
                    return new UserModel(userDTO);
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not log in", ex);
            }

        }

        public void UpdateUser(UserProfileModel user)
        {
            try
            {
                UserDTO userDTO = new UserDTO()
                {
                    ID = user.ID,
                    Name = user.Name,
                    Username = user.Username,
                    Email = user.Email
                };
                userRepository.UpdateUser(userDTO);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not update user", ex);
            }

        }

        public bool UsernameExists(string username)
        {
            try
            {
                return userRepository.UsernameExists(username);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not check username existance", ex);
            }
        }

        private string createPasswordHash(UserModel user, string salt)
        {
            try
            {
                string hash = HashingSalting.GenerateSHA256Hash(user.Password, salt);
                return hash;
            }
            catch (Exception ex)
            {
                throw new Exception("Could not hash the your password", ex);
            }
           
        }
    }
}