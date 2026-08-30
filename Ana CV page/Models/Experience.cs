namespace Ana_CV_page.Models;

public class Experience
{
    public int Id { get; set; }

    public string JobTitle { get; set; } = string.Empty;
    public string Company { get; set; } = string.Empty;

    public string? Location { get; set; }
    public string? WorkMode { get; set; }

    public DateOnly StartDate { get; set; }
    public DateOnly? EndDate { get; set; }

    public bool IsCurrent { get; set; }

    public string Description { get; set; } = string.Empty;

    public int SortOrder { get; set; }

    public List<string> Highlights { get; set; } = [];
}