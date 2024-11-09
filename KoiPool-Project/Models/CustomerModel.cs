using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
public class CustomerModel : IdentityUser
{
    [Key]
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}