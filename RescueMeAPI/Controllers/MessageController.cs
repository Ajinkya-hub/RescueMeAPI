using MyServices.Web;
using RescueMe.Models;
using RescueMe.Service.Interface;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RescueMeAPI.Controllers
{
    [RoutePrefix("RescueMe")]
    [ControllerExceptionFilter]
    public class MessageController : ApiController
    {
        IMessageService _message;
        public MessageController(IMessageService Message)
        {
            _message = Message;
        }

        [HttpPost]
        [Route("InformEmployees")]
        public HttpResponseMessage Post([FromBody] smsModel newSMS)
        {
            try
            {
                _message.SendMessage(newSMS);
                return Request.CreateResponse(HttpStatusCode.OK, "SMS Sent");
            }
            catch (Exception xcp)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, xcp.Message);
            }
        }
    }
}
