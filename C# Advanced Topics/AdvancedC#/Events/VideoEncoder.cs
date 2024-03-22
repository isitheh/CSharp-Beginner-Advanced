using System.Threading.Channels;

namespace AdvancedC_.Events;

public class VideoEncoder
{

    /*
     * Event - Subscriber
     * To set up an event and subscription to that event.
     * STEP 1: Define a delegate.
     *  This is a function that defines the event subscription contract
     * STEP 2: Define an event based on that delegate
     * STEP 3: Publish the Event
     * STEP 4: Ensure the classes that need the events are subscribed/registered.
     * STEP 4: Handle the event in all the subscribers.
     */
    //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
    //public event VideoEncodedEventHandler VideoEncodedEvent;

    //Define the same delegate differently - No behavioural change here.
    public event EventHandler<VideoEventArgs> VideoEncodedEvent;

    public void Encode(Video video)
    {
        //Encoding Logic
        //...
        Console.WriteLine("Encoding video with title {0}", video.Title);
        Thread.Sleep(3000);

        //When done with the encoding logic, publish event done.
        OnVideoEncodedEvent(video);   
    }

    protected virtual void OnVideoEncodedEvent(Video video)
    {
        if (VideoEncodedEvent != null)
        {
            VideoEncodedEvent(this.GetType(), new VideoEventArgs() { Video = video });
        }
    }
}