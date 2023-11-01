using Blog.Class.Entities;
using Blog.Class.Models;
using Blog.Class.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class.Repositories.Interfaces;

public interface IUserRepository
{
    (BaseResponseModel, List<User>) CreateUser(CreateUserViewModel model, List<User> users);
    (BaseResponseModel, List<User>) UpdateUser(int id, List<User> users, UpdateUserViewModel model);
    (BaseResponseModel, List<User>) DeleteUser(int id, List<User> user);
    (BaseResponseModel, User) GetUser(int id, List<User> users);
}
