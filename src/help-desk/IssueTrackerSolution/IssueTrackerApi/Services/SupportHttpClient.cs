namespace IssueTrackerApi.Services;

public class SupportHttpClient
{
    private readonly HttpClient _httpClient;

    public SupportHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<CurrentSupportResponse?> GetCurrentSupportInformatiaonAsync()
    {
        var response = await _httpClient.GetAsync("/");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadFromJsonAsync<CurrentSupportResponse>();
        return content;
    }
}

public record CurrentSupportResponse
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
}
