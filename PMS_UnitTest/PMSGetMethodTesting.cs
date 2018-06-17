using System;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMS_API.Controllers;

namespace PMS_UnitTest
{
    [TestClass]
    public class PMS_Test
    {
        [TestMethod]
        public void PMS_GetTesting()
        {
            var controller = new PMSController();
            var _result = controller.GetDetails() as OkNegotiatedContentResult<string>;
            Assert.AreEqual("Working....", _result.Content);
        }

        [TestMethod]
        public void PMS_GetTesting2()
        {
            var controller = new PMSController();
            var _result = controller.GetDetails() as OkNegotiatedContentResult<string>;
            Assert.IsNotNull(_result);
        }
    }
}
