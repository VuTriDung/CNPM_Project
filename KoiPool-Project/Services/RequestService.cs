using System;
using System.Linq;
using System.Collections.Generic;
using KoiPool_Project.Models; // For accessing CustomerModel
using Microsoft.EntityFrameworkCore; // For interacting with the DbContext
namespace KoiPool_Project.Services
{
    public class RequestService
    {
        public void CreateRequest(RequestModel request)
        {
            // Code để thêm yêu cầu vào database
        }

        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            // Code để cập nhật trạng thái của yêu cầu
        }

        public List<RequestModel> GetRequestsByCustomerId(int customerId)
        {
            // Code để lấy tất cả yêu cầu của một khách hàng
            return new List<RequestModel>();
        }
    }
}
