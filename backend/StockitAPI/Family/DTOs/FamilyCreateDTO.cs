namespace StockitAPI.Family.DTOs;

public class FamilyCreateDto
{
    public string? Name { get; set; } = string.Empty;
    public Guid UserId { get; set; }
}