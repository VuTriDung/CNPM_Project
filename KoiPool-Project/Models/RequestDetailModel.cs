using System.ComponentModel.DataAnnotations;
namespace KoiPool_Project.Models
{
    public class RequestDetailModel
    {
        public int DetailId { get; set; }
        public int RequestId { get; set; }
        public int ServiceId { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
