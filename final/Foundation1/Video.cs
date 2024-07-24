public class Video
{
    public string _title;
    public string _author;
    public string _videoLength;
    public List<Comment> _comments;

    public Video(string title, string author, TimeSpan videoLength, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _comments = comments;
        
        if (videoLength.Hours == 0)
        {
            _videoLength = $"{videoLength.Minutes}:{videoLength.Seconds:00}";
        }
        else
        {
            _videoLength = videoLength.ToString();
        }
    }

    public int GetCommentsAmount()
    {
        return _comments.Count;
    }
}