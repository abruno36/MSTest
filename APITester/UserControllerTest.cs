using APITestUnitario.Controllers;
using APITestUnitario.Entities;
using Microsoft.AspNetCore.Mvc;

namespace APITester
{
    [TestClass]
    public class UserControllerTest
    {
        UserController controller;
        User user;

        [TestInitialize]
        public void Start()
        {
            controller = new UserController();
            user = new User();  
        }

        [TestMethod]
        [DataRow("Bruno")]
        [DataRow("Eduardo")]
        [DataRow("Dudu")]
        public void Post_Teste_Ok(string nome)
        {
            user.Nome = nome;
            var responseAPI = controller.Post(user);
            Assert.IsInstanceOfType(responseAPI, typeof(OkResult));
        }
    }
}