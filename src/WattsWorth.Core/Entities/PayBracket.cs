namespace WattsWorth.Core.Entities;

public class PayBracket : BaseEntity
{
    public int MaxUnits { get; set; }
    public decimal PricePerUnit { get; set; }
}
