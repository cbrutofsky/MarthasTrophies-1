using System;
namespace MarthasTrophies.Models
{
    public class Product
    {
        //This class is meant to create the product
        public Product()
        {
        }

        //need to figure out how to add image for product

        public int ProductId { get; set; }

        public string ItemName { get; set; }

        public double ItemPrice { get; set; }

        public string ItemDimensions { get; set; }

        public string ItemDescription { get; set; }

        public string ItemType { get; set; }

        public string ItemCategory { get; set; }

        public string Image { get; set; }



    }
}
