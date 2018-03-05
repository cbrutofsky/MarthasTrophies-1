using System;
namespace MarthasTrophies.Models
{
    public class Order
    {
        //This class is meant to create the Order

        public Order()
        {
        }

        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }

        public double TotalPrice { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string StreetAddress { get; set; }

        public string Zipcode { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        //TODO: Need to add in OrderDetails
    }
}
