﻿namespace SignalRLab1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } 
        public int Price { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
