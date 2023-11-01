using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class.Models;

public class BaseResponseModel
{
    public bool Status { get; set; }
    public string? Message { get; set; }
}
