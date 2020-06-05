using DbService.Repository;
using Moq;
using ProjektTestowy.Controllers;
using ProjektTestowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testowy.Domain;
using Xunit;

namespace Testowy.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void User_Is_Succesfull_Registered()
        {
            //arrange
            var mock = new Mock<IRepository<User>>();
            mock.Setup(m => m.Get()).Returns(new List<User>());
            var controller = new HomeController(mock.Object);
            var testUser = new User
            {
                Login = "Login",
                Password = "pass",
                Name = "name",
                Email = "mail@mail.pl"
            };
           
            //act
            controller.Register(testUser);
            var expected = new List<User> { testUser };

            //assert
            Assert.Equal(1, expected.Count);
        }
    }
}
