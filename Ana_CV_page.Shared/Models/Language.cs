namespace Ana_CV_page.Models;

public class Language
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
    public string Proficiency { get; set; } = string.Empty;

    public int SortOrder { get; set; }
}