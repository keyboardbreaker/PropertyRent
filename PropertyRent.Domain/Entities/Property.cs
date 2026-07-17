namespace PropertyRent.Domain.Entities;

public class Property
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public decimal MonthlyRent { get; set; }
    public bool IsOccupied { get; set; }
}