namespace OpenRouterClient;

public static class OpenRouterModels
{
    public static class OpenAi
    {
        public const string Gpt4O = "openai/gpt-4o";
        public const string Gpt4O20240806 = "openai/gpt-4o-2024-08-06";
        public const string Gpt4O20240513 = "openai/gpt-4o-2024-05-13";
        public const string Gpt4OMini = "openai/gpt-4o-mini";
        public const string Gpt4OMini20240718 = "openai/gpt-4o-mini-2024-07-18";
        public const string ChatGpt4OLatest = "openai/chatgpt-4o-latest";
        public const string O1Preview = "openai/o1-preview";
        public const string O1Preview20240912 = "openai/o1-preview-2024-09-12";
        public const string O1Mini = "openai/o1-mini";
        public const string O1Mini20240912 = "openai/o1-mini-2024-09-12";
        public const string Gpt4Turbo = "openai/gpt-4-turbo";
        public const string Gpt4TurboPreview = "openai/gpt-4-turbo-preview";
        public const string Gpt4 = "openai/gpt-4";
        public const string Gpt432K = "openai/gpt-4-32k";
        public const string Gpt35Turbo = "openai/gpt-3.5-turbo";
        public const string Gpt35Turbo16K = "openai/gpt-3.5-turbo-16k";
    }
    
    public static class Anthropic
    {
        public const string Claude35Sonnet = "anthropic/claude-3.5-sonnet";
        public const string Claude35Haiku = "anthropic/claude-3.5-haiku";
        public const string Claude3Opus = "anthropic/claude-3-opus";
        public const string Claude3Sonnet = "anthropic/claude-3-sonnet";
        public const string Claude3Haiku = "anthropic/claude-3-haiku";
        public const string Claude21 = "anthropic/claude-2.1";
        public const string Claude20 = "anthropic/claude-2.0";
        public const string Claude2 = "anthropic/claude-2";
        public const string ClaudeInstant12 = "anthropic/claude-instant-1.2";
        public const string ClaudeInstant1 = "anthropic/claude-instant-1";
    }
    
    public static class Google
    {
        public const string GeminiPro15 = "google/gemini-pro-1.5";
        public const string GeminiFlash15 = "google/gemini-flash-1.5";
        public const string GeminiPro = "google/gemini-pro";
        public const string GeminiProVision = "google/gemini-pro-vision";
        public const string PaLm2Chat = "google/palm-2-chat-bison";
        public const string PaLm2CodeChat = "google/palm-2-codechat-bison";
    }
    
    public static class Meta
    {
        public const string Llama31405BInstruct = "meta-llama/llama-3.1-405b-instruct";
        public const string Llama3170BInstruct = "meta-llama/llama-3.1-70b-instruct";
        public const string Llama318BInstruct = "meta-llama/llama-3.1-8b-instruct";
        public const string Llama370BInstruct = "meta-llama/llama-3-70b-instruct";
        public const string Llama38BInstruct = "meta-llama/llama-3-8b-instruct";
        public const string CodeLlama34BInstruct = "meta-llama/codellama-34b-instruct";
        public const string CodeLlama13BInstruct = "meta-llama/codellama-13b-instruct";
        public const string CodeLlama7BInstruct = "meta-llama/codellama-7b-instruct";
        public const string Llama270BChat = "meta-llama/llama-2-70b-chat";
        public const string Llama213BChat = "meta-llama/llama-2-13b-chat";
        public const string Llama27BChat = "meta-llama/llama-2-7b-chat";
    }
    
    public static class DeepSeek
    {
        public const string DeepSeekR1 = "deepseek/deepseek-r1";
        public const string DeepSeekChat = "deepseek/deepseek-chat";
        public const string DeepSeekCoder = "deepseek/deepseek-coder";
    }
    
    public static class Perplexity
    {
        public const string Llama31SonarLarge128KOnline = "perplexity/llama-3.1-sonar-large-128k-online";
        public const string Llama31SonarSmall128KOnline = "perplexity/llama-3.1-sonar-small-128k-online";
        public const string Llama31SonarLarge128KChat = "perplexity/llama-3.1-sonar-large-128k-chat";
        public const string Llama31SonarSmall128KChat = "perplexity/llama-3.1-sonar-small-128k-chat";
    }
    
    public static class Amazon
    {
        public const string NovaProV1 = "amazon/nova-pro-v1";
        public const string NovaLiteV1 = "amazon/nova-lite-v1";
        public const string NovaMicroV1 = "amazon/nova-micro-v1";
    }
}