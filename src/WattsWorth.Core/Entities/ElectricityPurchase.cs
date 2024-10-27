namespace WattsWorth.Core.Entities;

public class ElectricityPurchase : BaseEntity
{
    public decimal Price { get; set; } // Price of the purchase
    public decimal UnitsPurchased { get; set; } // Units purchased
    public decimal PricePerUnit { get; set; } // Price per unit
    public string PaymentMethod { get; set; } // Optional: Payment method

    // Foreign key to the Transaction entity
    public int TransactionId { get; set; }
    public Transaction Transaction { get; set; } // Navigation property
}