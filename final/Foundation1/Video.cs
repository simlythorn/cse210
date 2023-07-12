using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }
    public List<Comment> Comments = new List<Comment>();
    public int GetNumberOfComment()
    {
        return Comments.Count;
    }


}