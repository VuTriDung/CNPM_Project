using System;
using System.Linq;
using System.Collections.Generic;
using KoiPool_Project.Models; // For accessing CustomerModel
using Microsoft.EntityFrameworkCore; // For interacting with the DbContext
namespace KoiPool_Project.Services
{
    public class CustomerService
    {
        public void CreateCustomer(CustomerModel customer)
        {
            // Code để thêm khách hàng vào database
        }

        public CustomerModel GetCustomerById(int customerId)
        {
            // Code để lấy thông tin khách hàng
            return new CustomerModel();
        }
    }
}
