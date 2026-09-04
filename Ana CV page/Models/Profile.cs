namespace Ana_CV_page.Models;

public class Profile
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string ProfessionalTitle { get; set; } = string.Empty;

    public string SummaryEnglish { get; set; } = string.Empty;
    public string SummarySwedish { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
    public string? Phone { get; set; }

    public string? LinkedInUrl { get; set; }
    public string? ProfileImageUrl { get; set; }
    public string? IntroVideoUrl { get; set; }

    public bool OpenToWork { get; set; }

    public string? PreferredWorkMode { get; set; }
}