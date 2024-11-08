using KoiPool_Project.Services;
using Microsoft.AspNetCore.Mvc;

public class CustomerController : Controller
{
    private readonly CustomerService _customerService;

    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpPost]
    public IActionResult CreateCustomer(CustomerModel customer)
    {
        _customerService.CreateCustomer(customer);
        return RedirectToAction("CustomerDetails", new { id = customer.CustomerId });
    }

    public IActionResult CustomerDetails(int id)
    {
        var customer = _customerService.GetCustomerById(id);
        return View(customer);
    }
}
