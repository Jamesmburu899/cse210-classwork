public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Method to return a summary of the assignment
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for student name (to be used in derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}