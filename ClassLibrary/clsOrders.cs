using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public DateTime DateOfOrder { get; set; }
        public int OrderNo { get; set; }
        public int ItemCount { get; set; }
        public bool Dispatched { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public string DeliveryNote { get; set; }
    }
}