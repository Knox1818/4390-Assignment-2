using Microsoft.EntityFrameworkCore;

//Here I seed the data with sellers, each with a car or cars to sell
namespace Final_Project_CarBag.Models
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
                    },
                    new Order{
                        Customer= "Gustavo Fring",
                        Address= "188 Willow Grove, Austin, Texas",
                        Email= "gustavofring@gmail.com",
                        Cars= new List<Car>{
                            new Car {Make="Ferrari", Model="812 Superfast", Color="Red with yellow stripe", Year=2020, Mileage=10000, Price=400000},
                            new Car {Make="Dodge", Model="Viper ACR", Color="Silver with black and red stripe", Year=2016, Mileage=8000, Price=200000},
                            new Car {Make="Mercedes-AMG", Model="GT Black Series", Color="Orange", Year=2021, Mileage=200, Price=350000},
                            new Car {Make="Chevrolet", Model="Camaro", Color="Forest green", Year=1969, Mileage=10000, Price=120000},
                            new Car {Make="Ford", Model="Mustang Boss", Color="Yellow with black accents", Year=1969, Mileage=5000, Price=100000},
                            new Car {Make="Ford", Model="Falcon", Color="Blue with silver accents", Year=1974, Mileage=10000, Price=80000},
                            new Car {Make="Pontiac", Model="Firebird Trans-Am", Color="White with blue striping", Year=1969, Mileage=8000, Price=250000},
                            new Car {Make="Chevrolet", Model="Corvette ZR1", Color="Red", Year=1970, Mileage=12000, Price=220000},
                            new Car {Make="Chevrolet", Model="Corvette ZR1", Color="Orange", Year=2019, Mileage=5000, Price=170000},
                            new Car {Make="Ford", Model="Mustang GT-500", Color="Blue with white stripes", Year=2021, Mileage=2500, Price=130000}
                        }
                    },
                );
                context.SaveChanges();
            }
        }
    }
}