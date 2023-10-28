namespace BlogClassLib.Entities;
public class User
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public string? UserName { get; set; }
    public DateTime DateJoined { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public List<User> Followers { get; set; } = new List<User>();
    public List<Blog> Blogs { get; set; } = new List<Blog>();
}
