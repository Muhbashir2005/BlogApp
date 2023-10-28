using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogClassLib.Models.Blog;

public class BlogViewModel : BaseResponseModel
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime Created { get; set; }
    public int Vote { get; set; }
}
