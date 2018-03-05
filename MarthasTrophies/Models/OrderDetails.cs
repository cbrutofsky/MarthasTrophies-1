using System;
namespace MarthasTrophies.Models
{
    public class OrderDetails
    {
        //This class is meant to create the Order Details

        public OrderDetails()
        {
        }

        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Engraving { get; set; }

        public string Comments { get; set; }

        public string PickupDate { get; set; }

        //TODO: add in virtual order and virtual product
    }
}
