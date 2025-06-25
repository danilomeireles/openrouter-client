using Microsoft.Extensions.Configuration;

namespace OpenRouterClient;

static class Program
{
    static async Task Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();
        
        var apiKey = config["OpenRouter:ApiKey"]!;
        var referer = config["OpenRouter:Referer"]!;
        var client = new OpenRouterClient(apiKey, referer, OpenRouterModels.Anthropic.Claude3Sonnet);

        Console.WriteLine("OpenRouter Console Client");
        Console.WriteLine("Type your prompt below (type 'exit' to quit):");

        while (true)
        {
            Console.Write("\n> ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "exit")
                break;

            try
            {
                var response = await client.SendPromptAsync(input);
                Console.WriteLine($"\n🤖 {response}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}