using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLib.Models.User;

public class UpdateUserViewModel : BaseResponseModel
{
    public string? FullName { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
}
