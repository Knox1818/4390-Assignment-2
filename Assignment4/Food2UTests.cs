using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Food2U.Tests
{
    public class CustomerManagementTests
    {
        [Fact]
        public async Task Test_CreateAccount_Successful()
        {
            // Arrange
            var logger = Mock.Of<ILogger<RegisterModel>>();
            var model = new RegisterModel(logger)
            {
                Input = new RegisterModel.InputModel
                {
                    Name = "Walter White",
                    Email = "heisenberg@gmail.com",
                    Password = "Walter123"
                }
            };

            // Act
            var result = await model.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.Equal("/Login", redirectResult.PageName);
        }

        [Fact]
        public async Task Test_Login_Successful()
        {
            // Arrange
            var logger = Mock.Of<ILogger<LoginModel>>();
            var model = new LoginModel(logger)
            {
                Input = new LoginModel.InputModel
                {
                    Email = "heisenberg@gmail.com",
                    Password = "Walter123"
                }
            };

            // Act
            var result = await model.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.Equal("/Index", redirectResult.PageName);
        }

        [Fact]
        public async Task Test_EditAccount_Successful()
        {
            // Arrange
            var logger = Mock.Of<ILogger<AccountModel>>();
            var model = new AccountModel(logger)
            {
                Input = new AccountModel.InputModel
                {
                    Name = "Walter White",
                    Email = "heisenberg@gmail.com"
                }
            };

            // Act
            var result = await model.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.Equal("/Account", redirectResult.PageName);
        }
        public class PaymentManagementTests
        {
            [Fact]
            public void Test_ProcessPayment()
            {
            // Arrange
            var cart = new Cart();
            cart.AddItem(new MenuItem("Cheeseburger", 5.99));
            var payment = new Payment("Walter White", "1234567890123456", "123", DateTime.Now.AddMonths(1), 50);

            // Act
            var result = PaymentProcessor.ProcessPayment(cart, payment);
            
            // Assert
            Assert.True(result.Success);
            Assert.NotNull(result.TransactionId);
            }

            [Fact]
            public void Test_ViewSalesHistory()
            {
                // Arrange
                var restaurant = new Restaurant("KFC");
                var order1 = new Order(DateTime.Now.AddDays(-2), new List<CartItem> { new CartItem(new MenuItem("Fried chicken", 7.99), 2) });
                var order2 = new Order(DateTime.Now.AddDays(-1), new List<CartItem> { new CartItem(new MenuItem("Mashed potatoes", 3.99), 1), new CartItem(new MenuItem("Coleslaw", 2.99), 1) });
                order1.Pay(new Payment("Gus Fring", "1234567890123456", "123", DateTime.Now.AddMonths(1), 20));
                order2.Pay(new Payment("Jesse Pinkman", "9876543210987654", "456", DateTime.Now.AddMonths(2), 10));
                restaurant.Orders.Add(order1);
            }
        }
    }
}