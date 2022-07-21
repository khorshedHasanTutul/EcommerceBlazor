using Bunit;
using EcommerceWebAsmb.Client.Pages;
using EcommerceWebAsmb.Server.Services.AuthService;
using EcommerceWebAsmb.Shared;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace DemoUnitTest
{
    public class Tests
    {
        private Bunit.TestContext _testContext;
        private Mock<IAuthService> AuthService;

        [SetUp]
        public void Setup()
        {
            _testContext = new Bunit.TestContext();
        }
        [TearDown]

        public void Teardown()
        {
            _testContext.Dispose();
        }

        [Test]

        public void EmptyEmailPasswordValidationTest()
        {
            _testContext.Services.AddScoped(x => AuthService.Object);
            var component = _testContext.RenderComponent<Registration>();
            Assert.IsTrue(component.Markup.Contains("<h3>Registration</h3>"));
            var buttons = component.FindAll("button");
            Assert.AreEqual(1, buttons.Count);

            var submit = buttons.FirstOrDefault(b => b.OuterHtml.Contains("Registration"));
            Assert.IsNotNull(submit);

            //submit.Click();
            var user = new User { Email="tonmoy@mm.sss" }; //It.IsAny<User>();
            var pass = "123";//It.IsAny<string>();
            AuthService.Verify(chkRegister => chkRegister.Register(user, pass),Times.Never);
        }
    }
}