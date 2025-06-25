using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenRouterClient;

public class OpenRouterClient
{
    private readonly HttpClient _httpClient;
    private const string Model = "anthropic/claude-3-sonnet";

    public OpenRouterClient(string apiKey, string referer)
    {
        _httpClient = new HttpClient
        {
            BaseAddress = new Uri("https://openrouter.ai/")
        };

        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        _httpClient.DefaultRequestHeaders.Add("HTTP-Referer", referer);
        _httpClient.DefaultRequestHeaders.Add("X-Title", "Console App");
    }

    public async Task<string> SendPromptAsync(string prompt)
    {
        var request = new
        {
            model = Model,
            messages = new[]
            {
                new { role = "user", content = prompt }
            }
        };

        var content = new StringContent(JsonSerializer.Serialize(request), Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync("api/v1/chat/completions", content);

        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadAsStringAsync();
            throw new Exception($"API Error: {response.StatusCode} - {error}");
        }

        await using var stream = await response.Content.ReadAsStreamAsync();
        var result = await JsonSerializer.DeserializeAsync<ChatResponse>(stream);

        return result?.Choices[0].Message.Content ?? "[No response]";
    }
}

public class ChatResponse
{
    [JsonPropertyName("choices")]
    public List<ChatChoice> Choices { get; set; } = [];
}

public class ChatChoice
{
    [JsonPropertyName("message")]
    public ChatMessage Message { get; set; } = null!;
}

public class ChatMessage
{
    [JsonPropertyName("content")]
    public string Content { get; set; } = null!;
}
