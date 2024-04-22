namespace Blog;

public static class Configuration
{
    public static string JwtKey { get; set; } = "92740520-786A-48DC-A64F-AD7523C42489";
    public static string ApiKeyName { get; set; } = "api_key";
    public static string ApiKey { get; set; } = "api_92740520-786A-48DC-A64F-AD7523C42489";
    public static SmtpConfiguration Smtp = new();


    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 25;
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
