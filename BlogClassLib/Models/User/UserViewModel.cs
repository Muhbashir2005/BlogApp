using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLib.Models.User;

public class UserViewModel : BaseResponseModel
{
    public string? FullName { get; set; }
    public string? UserName { get; set; }
    public int FollowersCount { get; set; }
    public int BlogsCount { get; set; }
    public string? Email { get; set; }
    public DateTime DateJoined { get; set; }
}
