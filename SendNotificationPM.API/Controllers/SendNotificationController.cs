using Microsoft.AspNetCore.Mvc;
using SendNotificationPM.Application.DTOs.Request;

namespace SendNotificationPM.API.Controllers
{
    [Route("api/v1/send-notification")]
    [ApiController]
    public class SendNotificationController : ControllerBase
    {
        // POST api/<SendNotification>
        [HttpPost]
        public void Push([FromBody] NotificationRequest notificationRequest)
        {
            notificationRequest.Validate();
            
            
            
            
        }
    }
}
