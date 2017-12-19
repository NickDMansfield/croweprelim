using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1;
using WebApplication1.Controllers;
using WebApplication1.Models;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace crowePelimUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PostLoggingMessageOK()
        {
            var controller = new LoggingController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };


            loggingMessage testMsg = new loggingMessage();
            testMsg.msg = "Howdy world!!";
            HttpResponseMessage result = controller.postMessage(testMsg);
            var resultText = result.Content as ObjectContent;
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(testMsg, resultText.Value);
        }

        [TestMethod]
        public void PostLoggingMessageBadRequest()
        {
            var controller = new LoggingController
            {
                Request = new System.Net.Http.HttpRequestMessage(),
                Configuration = new HttpConfiguration()
            };


            loggingMessage testMsg = new loggingMessage();
            testMsg.sender = "Doc Brown";
            HttpResponseMessage result = controller.postMessage(testMsg);
            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, result.StatusCode);
            Assert.AreEqual("Please submit a message value", result.Content.ReadAsAsync<HttpError>().Result.Message);
        }
    }
}
