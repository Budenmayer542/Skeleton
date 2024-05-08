using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public DateTime DateAdded { get; set; }
        public int OrderNo { get; set; }
        public int ItemCount { get; set; }
        public bool Dispatched { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public string DeliveryNote { get; set; }
    }
}