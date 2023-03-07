using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using RazorPagesSample.Pages;
using RazorPagesSample.Models;

namespace RazorPagesSample.Tests
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
                    Email = "johndoe@example.com",
                    Password = "P@ssw0rd!"
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
                    Name = "Jane Doe",
                    Email = "janedoe@example.com"
                }
            };

            // Act
            var result = await model.OnPostAsync();

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.Equal("/Account", redirectResult.PageName);
        }
    }
}