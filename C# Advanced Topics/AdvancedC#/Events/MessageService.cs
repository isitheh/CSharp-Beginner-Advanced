namespace AdvancedC_.Events;

public class MessageService
{
    /*
     * MessageService:
     * This class is responsible for sending a sms once video is encoded.
     */
    public void OnVideoEncodedEvent(object source, VideoEventArgs e)
    {
        Console.WriteLine("MessageService: Sending an sms." + e.Video.Title);
    }
}