﻿namespace CQRSDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public decimal Quantity { get; set; }
    }
}