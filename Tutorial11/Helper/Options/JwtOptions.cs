namespace Tutorial11.Helper.Options;

public class JwtOptions
{
    public required string Issuer { get; set; }
    
    public required string Audience { get; set; }
    
    public required string Key { get; set; }
    
    public required int ValidInMinutes { get; set; }
}