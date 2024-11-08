using System.ComponentModel.DataAnnotations;
namespace KoiPool_Project.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string SkillLevel { get; set; } 
    }
}
