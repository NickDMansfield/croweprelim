using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class LoggingController : ApiController
    {
        [HttpPost]
        [ActionName("Complex")]
        [Route("api/logging")]
        public HttpResponseMessage postMessage([FromBody] loggingMessage msg)
        {

            if (msg.msg == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Please submit a message value");
            }
            sharedActions.writeMessage("Message:" + msg.msg + "\r\n Sender:" + msg.sender);
            return Request.CreateResponse(HttpStatusCode.OK, msg);
        }

        [HttpGet]
        [Route("api/logging")]
        public HttpResponseMessage Get()
        {
            sharedActions.writeMessage("Helllloooooo world!");
            return Request.CreateResponse(HttpStatusCode.OK, "Hello friend");
        }
    }
}
