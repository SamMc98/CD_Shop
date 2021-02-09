using System;

namespace TestingOrders
{
    public class clsOrders
    {
        public bool OrderPlaced { get; set; }
        public DateTime CheckoutDate { get; internal set; }
        public DateTime DeliveryDate {get; internal set;}
        public string ShippingAddress { get; internal set; }
        public int OrderID { get; internal set; }
        public int OrderLineID { get; internal set; }
        public bool OrderLineCheckout { get; internal set; }
        public int OrderLineTotal { get; internal set; }
        public double TotalCost { get; internal set; }
    }
}
