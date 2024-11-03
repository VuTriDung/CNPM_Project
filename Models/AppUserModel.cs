using Microsoft.AspNetCore.Identity;

namespace KoiPool_Project.Models

{
    public class AppUserModel : IdentityUser
    {
        public string Occupation {  get; set; }
        public string Address { get; set; }
        public string NamePool { get; set; }
        public int Price { get; set; }
    }
}
