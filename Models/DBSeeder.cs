namespace OData_Code_Example.Models
{
    public class DBSeeder
    {
        public static void AddCompaniesData(WebApplication app)
        {
            var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetService<ApiContext>();

            db.Companies.Add(
                new Company()
                {
                    ID = 1,
                    Name = "Company A",
                    Size = 25
                });
            
            db.Companies.Add(
                new Company()
                {
                    ID = 2,
                    Name = "Company B",
                    Size = 20
                });
            
            db.Companies.Add(
                new Company()
                {
                    ID = 3,
                    Name = "Company C",
                    Size = 30
                });

            
            db.Products.Add(
                new Product()
                {
                    ID = 1,
                    CompanyID = 1,
                    Name = "Product A",
                    Price = 10
                });

            db.Products.Add(
                new Product()
                {
                    ID = 2,
                    CompanyID = 1,
                    Name = "Product B",
                    Price = 20
                });

            db.Products.Add(
                new Product()
                {
                    ID = 3,
                    CompanyID = 2,
                    Name = "Product C",
                    Price = 10
                });

            db.Products.Add(
                new Product()
                {
                    ID = 4,
                    CompanyID = 3,
                    Name = "Product D",
                    Price = 15
                });

            db.SaveChanges();
        }
    }
}
