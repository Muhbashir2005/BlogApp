using Blog.Class.Entities;
using Blog.Class.Models;
using Blog.Class.Models.User;
using Blog.Class.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Blog.Class.Repositories.Implementations;

public class UserRepository : IUserRepository
{
    public (BaseResponseModel, List<User>) CreateUser(CreateUserViewModel model, List<User> usersList)
    {
        User user = new()
        {
            Id = model.Id,
            FullName = model.FullName,
            UserName = model.UserName,
            DateJoined = DateTime.Now,
            Email = model.Email,
            Password = model.Password
        };

        usersList.Add(user);    

        List<User> users = new();

        users = usersList;

        BaseResponseModel response = new()
        {
            Status = true,
            Message = "User Created Successfully"
        };

        return (response, users);
    }

    public (BaseResponseModel, List<User>) DeleteUser(int id, List<User> usersList)
    {
        List<User> users = new();
        users = usersList;
        BaseResponseModel response = new()
        {
            Status = true,
            Message = "Successfully Deleted"
            //Epa Ojo Marun lofin Shere Yen
        };

        foreach (var item in usersList)
        {
            if (item.Id == id)
            {
                users.Add(item);
                return (response, users);
            }
        }

        response.Status = false;
        response.Message = $"Can't find user with id {id}";

        return (response, users);
    }

    public (BaseResponseModel, User) GetUser(int id, List<User> users)
    {
        User user = new User();

        BaseResponseModel response = new()
        {
            Status = true,
            Message = "User Retrieved"
        };

        foreach (var item in users)
        {
            if (item.Id == id)
            {
                user = item;
                return (response, user);
            }
        }

        response.Status = false;
        response.Message = "User not found";

        return (response, user);
    }

    public (BaseResponseModel, List<User>) UpdateUser(int id, List<User> usersList, UpdateUserViewModel model)
    {
        BaseResponseModel response = new()
        {
            Status = true,
            Message = "Updated Succesfully"
        };
        List<User> users = usersList;
        User user = new();


        foreach (var item in users)
        {
            if(item.Id == id)
            {
                item.FullName = model.FullName;
                item.UserName = model.UserName;
                item.Email = model.Email;

                return (response, users);
            }
        }
        response.Status = false;
        response.Message = "Failed To Update";
        return (response, users);
    }
}
