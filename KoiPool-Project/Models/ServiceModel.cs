﻿using System.ComponentModel.DataAnnotations;
namespace KoiPool_Project.Models
{
    public class ServiceModel
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal BasePrice { get; set; }
    }
}
