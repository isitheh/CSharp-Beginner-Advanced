using System;
using AdvancedC_.HandlingExceptions;

public class YouTubeApi
{
    public List<YouTubeVideo> GetYouTubeVideos(string user)
    {
        try
        {
            //Access  YouTube web service
            //Read the data
            //Create a list of YouTube video objects
            throw new Exception("Some low level Youtube exception.");
        }
        catch (Exception ex)
        {
            // ignored
            throw new YouTubeException("Could not fetch the videos from YouTube..", ex);
        }

        return new List<YouTubeVideo>();
    }
}