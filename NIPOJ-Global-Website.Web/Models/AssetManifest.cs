namespace NIPOJ_Global_Website.Web.Models;

public class AssetManifest
{
    public string Logo { get; set; } = string.Empty;
    public string Hero { get; set; } = string.Empty;
    public string MaritimeOilGas { get; set; } = string.Empty;
    public string Diving { get; set; } = string.Empty;
    public string Power { get; set; } = string.Empty;
    public List<string> Certs { get; set; } = new();
}
