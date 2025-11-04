namespace AegisApi.API.DTO;

public class VaultItemDto
{
    public string Ciphertext { get; set; } = string.Empty;
    public string Nonce { get; set; } = string.Empty;
    public string AuthTag { get; set; } = string.Empty;
}