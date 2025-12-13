using System;

public class Invoice : IPayable
{
   public string PartNumber { get; }
   public string PartDescription { get; }
   private int quantity;
   private decimal pricePerItem;

   // four-parameter constructor
   public Invoice(string partNumber, string partDescription, int quantity,
      decimal pricePerItem)
   {
      PartNumber = partNumber;
      PartDescription = partDescription;
      Quantity = quantity; // validate quantity 
      PricePerItem = pricePerItem; // validate price per item 
   }

   // property that gets and sets the quantity on the invoice
   public int Quantity
   {
      get
      {
         return quantity;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(Quantity)} must be >= 0");
         }

         quantity = value;
      }
   }

   // property that gets and sets the price per item
   public decimal PricePerItem
   {
      get
      {
         return pricePerItem;
      }
      set
      {
         if (value < 0) // validation
         {
            throw new ArgumentOutOfRangeException(nameof(value),
               value, $"{nameof(PricePerItem)} must be >= 0");
         }

         pricePerItem = value;
      }
   }

   // return string representation of Invoice object
   public override string ToString() =>
      $"invoice:\npart number: {PartNumber} ({PartDescription})\n" +
      $"quantity: {Quantity}\nprice per item: {PricePerItem:C}";

   // method required to carry out contract with interface IPayable
   public decimal GetPaymentAmount() => Quantity * PricePerItem;
}
