using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // The constructor passes the name and topic up to the base class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
