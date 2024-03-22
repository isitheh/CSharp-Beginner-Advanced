namespace AdvancedC_.Events;

public class MailService
{
    /*
     * MailService:
     * This class is responsible for sending an email once video is encoded.
     */
    public void OnVideoEncodedEvent(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an email." + e.Video.Title);
    }
}