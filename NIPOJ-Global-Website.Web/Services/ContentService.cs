using System.Net.Http.Json;
using NIPOJ_Global_Website.Web.Models;

namespace NIPOJ_Global_Website.Web.Services;

public class ContentService
{
    private readonly HttpClient httpClient;
    private SiteContent? content;

    public ContentService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public SiteContent? Content => content;
    public bool IsLoaded { get; private set; }
    public string? Error { get; private set; }

    public async Task InitializeAsync()
    {
        if (IsLoaded)
        {
            return;
        }

        try
        {
            Error = null;
            content = await httpClient.GetFromJsonAsync<SiteContent>("Content/sitecontent.json");
            IsLoaded = content is not null;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
            content ??= new SiteContent();
            IsLoaded = false;
        }
    }

    public async Task<SiteContent> GetContentAsync()
    {
        if (content is null)
        {
            await InitializeAsync();
        }

        return content ?? new SiteContent();
    }
}
