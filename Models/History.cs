using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KoiPool_Project.Models
{
    public class History
    {
        [Key]
        public string Id { get; set; }

        public string NamePool { get; set; }

        public int Price { get; set; }
    }
}
