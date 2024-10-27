namespace WattsWorth.Core.Entities;

public class ElectricityPurchase : BaseEntity
{
    public DateTime TransactionDate { get; set; } // When the purchase was made
    public decimal Price { get; set; } // Total price paid
    public decimal UnitsPurchased { get; set; } // Number of units purchased
    public decimal PricePerUnit { get; set; } // Calculated price per unit
    public string PaymentMethod { get; set; } // Payment method (optional)

    // Foreign key relationship to Transaction
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; }
}