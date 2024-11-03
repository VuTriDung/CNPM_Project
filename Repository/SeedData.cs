using KoiPool_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace KoiPool_Project.Repository
{
    public static class SeedData
    {
        public static void SeedingData(DataContext context)
        {
            if (!context.Histories.Any())
            {
                var hocacanh = new History { Id = "012", NamePool = "Ho ca ngoai troi", Price = 500000 };
                var hocatrongnha = new History { Id = "013", NamePool = "Ho ca trong nha", Price = 1000000 };
                context.Histories.AddRange(hocacanh, hocatrongnha);
                context.SaveChanges();
            }
        }

        internal static void SeedingData(global::DataContext context1)
        {
        }
    }
}
