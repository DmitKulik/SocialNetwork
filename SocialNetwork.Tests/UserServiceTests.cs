using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        UserService userService;
        [SetUp]
        public void SetUp()
        {
            userService = new UserService();
        }
        [Test]
        public void RegisterShouldThrowExceptionsIfInputIsIncorrect()
        {
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "Test",
                Password = "",
                Email = "Test@gmail.com"
            }));
        }
    }
}