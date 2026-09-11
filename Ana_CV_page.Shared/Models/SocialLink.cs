namespace Ana_CV_page.Models;

public class SocialLink
{
    public int Id { get; set; }

    public string Platform { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;

    public int SortOrder { get; set; }
}