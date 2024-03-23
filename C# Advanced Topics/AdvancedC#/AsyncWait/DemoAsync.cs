using System;
using System.Net;

public class DemoAsync
{
	public DemoAsync()
	{
	}

    public void DownloadHtml(string url)
    {
        var webClient = new WebClient();
        var html = webClient.DownloadString(url);

        using (var streamWriter 
            = new StreamWriter(
            @"C:\Users\gamas1\Downloads\Devtests\result.html"))
        {
            streamWriter.Write(html);
        }
    }

    public async Task DownloadHtmlAsync(string url)
    {
        var webClient = new WebClient();
        //The await keyword tells the compiler that this function may take a while
        //So the compiler will not block but return the operation to the caller asap.
        //This way, the UI will not be frozen and operation will resume when required.
        var html = await webClient.DownloadStringTaskAsync(url);

        using (var streamWriter
               = new StreamWriter(
                   @"C:\Users\gamas1\Downloads\Devtests\result.html"))
        {
            await streamWriter.WriteAsync(html);
        }
    }

    public string GetHtml(string url)
    {
        var webClient = new WebClient();
        return webClient.DownloadString(url);
    }

    public async Task<string> GetHtmlAsync(string url)
    {
        var webClient = new WebClient();
        return await webClient.DownloadStringTaskAsync(url);
    }
}
