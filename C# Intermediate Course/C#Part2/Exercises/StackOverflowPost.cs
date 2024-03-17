using System;

public class StackOverflowPost
{
    public string Title { get; set; }
    public string Description { get; set; }
	public DateTime TimeCreated { get; set; }
    private int _postVotes;
	public StackOverflowPost()
    {
        _postVotes = 0;
    }

    public void UpVotePost()
    {
        _postVotes++;
    }

    public void DownVotePost()
    {
        _postVotes--;
    }

    public int GetPostVotes()
    {
        return _postVotes;
    }
}
