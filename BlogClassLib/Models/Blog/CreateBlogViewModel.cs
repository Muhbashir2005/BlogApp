using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Class.Models.Blog;

public class CreateBlogViewModel : BaseResponseModel
{
    public string? Title { get; set; }
    public string? Content { get; set; }
}
