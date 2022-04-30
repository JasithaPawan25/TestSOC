using DrugManageService.Data.Models;

namespace DrugManageService.Data
{
    public class AppDbInitiazer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Suppliers.Any())
                {
                    context.Suppliers.AddRange(new Supplier()
                    {
                        Name ="Jasitha Pawan",
                        Address ="Morontota,Kegalle",
                        Contact = 159789,
                        DrugName ="Panadol",
                        price =20.00

                    },
                    new Supplier()
                    {
                        Name = "Umega Nagiranga",
                        Address = "Matara,Sri Lanka",
                        Contact = 15874,
                        DrugName = "dompiriton",
                        price = 18.00

                    }

                    );

                    context.SaveChanges();
                }
            }
        }
    }
}
