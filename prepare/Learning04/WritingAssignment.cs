using System;

public class WritingAssignment : Assignment
{
    private string _title; 

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public void SetWritingInformation(string title, string studentName)
    {
        _title = title;
        _studentName = studentName;
    }
    public string GetWritingInformation()
    {
        return $"title: {_title} by {_studentName}"; 
    }
}