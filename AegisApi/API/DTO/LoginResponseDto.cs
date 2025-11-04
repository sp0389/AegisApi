namespace AegisApi.API.DTO;

public class LoginResponseDto
{
    public string Token { get; set; } = string.Empty;
    public string EncryptionSalt { get; set; } = string.Empty;
    public string EncryptedDataKey { get; set; } = string.Empty;
    public string Nonce { get; set; } = string.Empty;
    public string AuthTag { get; set; } = string.Empty;
}