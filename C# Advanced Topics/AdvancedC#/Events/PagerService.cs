namespace AdvancedC_.Events;

public class PagerService
{
    /*
     * PagerService:
     * This class is responsible for sending a pager once video is encoded.
     */
    public void OnVideoEncodedEvent(object source, VideoEventArgs e)
    {
        Console.WriteLine("MessageService: Sending a pager." + e.Video.Title);
    }
}