using SendNotificationPM.Domain.Enums;

namespace SendNotificationPM.Application.DTOs.Request;

public class NotificationRequest
{
    public string Title { get; set; }
    
    public string Message { get; set; }

    public NotificationTypeEnum NotificationType { get; set; }

    public Person Sender { get; set; }
    
    public Person Recipient { get; set; }

    public DateTime RetryUntil { get; set; }
    
    public void Validate()
    {
        if (Message == null || Title == null)
        {
            throw new ArgumentNullException(nameof(NotificationRequest));
        }

        if (RetryUntil < DateTime.Now)
        {
            throw new Exception("RetryUntil Date must be in the future");
        }
    }
}