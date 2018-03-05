using System;
namespace MarthasTrophies.Models
{
    public class Cart
    {
        //This class is meant to create the Cart

        public Cart()
        {
        }

        //TODO: Add in virtual album
        public int CartId;

        public int ProductId { get; set; }

        public int OrderId { get; set; }

        public int Count { get; set; }
    }
}
