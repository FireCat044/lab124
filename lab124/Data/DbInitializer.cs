using lab124.Models;

namespace lab124.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Companies.Any())
            {
                return;
            }

            var companies = new Company[]
            {
                new Company { Name = "Company A", Address = "Address A", EmployeeCount = 100 },
                new Company { Name = "Company B", Address = "Address B", EmployeeCount = 50 },
                new Company { Name = "Company C", Address = "Address C", EmployeeCount = 75 },
                new Company { Name = "Company D", Address = "Address D", EmployeeCount = 120 },
                new Company { Name = "Company E", Address = "Address E", EmployeeCount = 30 }
            };

            context.Companies.AddRange(companies);
            context.SaveChanges();
        }
    }
}
