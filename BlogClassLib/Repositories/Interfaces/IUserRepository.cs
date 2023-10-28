using BlogClassLib.Entities;
using BlogClassLib.Models;
using BlogClassLib.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLib.Repositories.Interfaces;

public interface IUserRepository
{
    (BaseResponseModel, List<User>) CreateUser(CreateUserViewModel model, List<User> users);
    (BaseResponseModel, List<User>) UpdateUser(UpdateUserViewModel model);
    (BaseResponseModel, List<User>) DeleteUser(int id, List<User> user);
    (BaseResponseModel, User) GetUser(int id, List<User> users, UpdateUserViewModel model);
}
