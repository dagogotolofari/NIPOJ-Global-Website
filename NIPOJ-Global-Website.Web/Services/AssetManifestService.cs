using System.Net.Http.Json;
using NIPOJ_Global_Website.Web.Models;

namespace NIPOJ_Global_Website.Web.Services;

public class AssetManifestService
{
    private readonly HttpClient httpClient;
    private AssetManifest? manifest;

    public AssetManifestService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public string Logo => manifest?.Logo ?? string.Empty;
    public string Hero => manifest?.Hero ?? string.Empty;
    public string MaritimeOilGas => manifest?.MaritimeOilGas ?? string.Empty;
    public string Diving => manifest?.Diving ?? string.Empty;
    public string Power => manifest?.Power ?? string.Empty;
    public IReadOnlyList<string> Certs => manifest?.Certs ?? new List<string>();

    public async Task<AssetManifest> GetManifestAsync()
    {
        if (manifest is null)
        {
            manifest = await httpClient.GetFromJsonAsync<AssetManifest>("assets/asset-manifest.json") ?? new AssetManifest();
        }

        return manifest;
    }
}
