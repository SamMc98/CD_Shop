using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public bool OrderPlaced { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string ShippingAddress { get; set; }
        public int OrderID { get; set; }
        public int OrderLineID { get; set; }
        public bool OrderLineCheckout { get; set; }
        public int OrderLineTotal { get; set; }
        public double TotalCost { get; set; }
        }
    }