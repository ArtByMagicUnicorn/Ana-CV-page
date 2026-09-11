namespace Ana_CV_page.Models
{ 
public class Certification
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;
    public string? Issuer { get; set; }
    public string? Description { get; set; }

    public string? FileUrl { get; set; }

    public int SortOrder { get; set; }
}
}