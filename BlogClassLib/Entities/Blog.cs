namespace BlogClassLib.Entities;

public class Blog
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }
    public int VoteCount { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
}
