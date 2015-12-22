using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreMaterial.Controllers;
using System.Web.Mvc;

namespace StoreMaterial.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void Login()
        {
            AccountController controller = new AccountController();
            ViewResult vResult = (ViewResult)controller.Login();
            Assert.IsNotNull(vResult);
        }
    }
}
