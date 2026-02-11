namespace NIPOJ_Global_Website.Web.Models;

public class SiteContent
{
    public string CompanyName { get; set; } = string.Empty;
    public string RCNumber { get; set; } = string.Empty;
    public string Established { get; set; } = string.Empty;
    public string Tagline { get; set; } = string.Empty;
    public string AboutText { get; set; } = string.Empty;
    public string MissionText { get; set; } = string.Empty;
    public List<string> CoreCompetencies { get; set; } = new();
    public List<ServiceItem> Services { get; set; } = new();
    public List<string> QualityPolicyObjectives { get; set; } = new();
    public List<string> LocalContentPolicy { get; set; } = new();
    public List<string> Certifications { get; set; } = new();
    public string PartnershipsText { get; set; } = string.Empty;
    public ContactDetails Contact { get; set; } = new();
}

public class ServiceItem
{
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class ContactDetails
{
    public string Address { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone1 { get; set; } = string.Empty;
    public string Phone2 { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
}
