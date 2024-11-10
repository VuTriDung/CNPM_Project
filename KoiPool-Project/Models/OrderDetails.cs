﻿namespace KoiPool_Project.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string OrderCode { get; set; }
        public string ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

    }
}
