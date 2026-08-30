namespace Ana_CV_page.Models;

public class Education
{
    public int Id { get; set; }

    public string School { get; set; } = string.Empty;
    public string Program { get; set; } = string.Empty;

    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public string? Description { get; set; }

    public int SortOrder { get; set; }
}