using System.ComponentModel.DataAnnotations;
namespace KoiPool_Project.Models
{
    public class RequestModel
    {
        public int RequestId { get; set; }
        public int CustomerId { get; set; }
        public string RequestType { get; set; } // "Thi công", "Bảo dưỡng"
        public DateTime RequestDate { get; set; }
        public string Status { get; set; } // "Chờ xử lý", "Hoàn thành"
        public string Description { get; set; }
        public decimal TotalCost { get; set; }
    }
}
