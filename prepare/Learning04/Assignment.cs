public class Assignment
{
    // Create string variables student and topic
    private string _studentName;
    private string _topic;

    //Created a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

     public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    //Add the method for GetSummary() to return the student's name and the topic.
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}