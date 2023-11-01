using Blog.Class.Models;

namespace BlogApp.Services.Interfaces
{
    public interface IUserService
    {
        BaseResponseModel CreateUser();
        BaseResponseModel UpdateUser();
        BaseResponseModel Login();
        BaseResponseModel DeleteUser();
    }
}