using PostsMiniProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsMiniProject.Services.IService
{
    public interface IUser
    {
        Task<string> AddNewUser(AddUser newUser);

        Task<List<User>> GetAllUser();

        Task<User> GetUserById(int id);
    }
}
