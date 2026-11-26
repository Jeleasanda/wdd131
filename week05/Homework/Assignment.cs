using System;

public class Assignment
{
    // Protected allows derived classes to access these while keeping them hidden from the outside
    protected string _studentName;
    protected string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter needed so derived classes can access the private name
    public string GetStudentName()
    {
        return _studentName;
    }
}
