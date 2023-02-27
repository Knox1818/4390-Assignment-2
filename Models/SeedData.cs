using Microsoft.EntityFrameworkCore;
namespace _4390_Assignment_2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new Context(serviceProvider.GetRequiredService<DbContextOptions<Context>>())){
                if (context.sellers.Any())
                {
                    return;
                }
                context.customers.AddRange(
                    new Customer{
                        CustomerID= 1,
                        Address= "308 Negra Arroyo Lane, Albuquerque, New Mexico",
                        Name= "Walter White",
                        Email= "heisenberg@gmail.com"
                    }
                );
                context.deliveries.AddRange(
                    new Delivery{
                        DeliveryID= 1,
                        Driver= "Jesse Pinkman",
                        DeliveryTime= "May 6th 2007, 5:56, 10 minutes"
                    }
                );
                context.orders.AddRange(
                    new Order{
                        OrderID= 1,
                        Food= "Chicken combo, fries",
                        Restaurant= "Los Pollos Hermanos",
                        ResAddress= "225 Power Street, Albuquerque, New Mexico"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}