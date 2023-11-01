using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLib.Models.User;

public class LoginViewModel
{
    public string? Password { get; set; }
    public string? UserNameOrEmail { get; set; }
    public string? ConfirmPassword { get; set; }
}
