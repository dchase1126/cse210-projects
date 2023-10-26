
class Assignments  // base or super class
{
    private string _studentName;    //protected is an option over private
    private string _topic;

    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() //method
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName()  // to be used if variable is private, but not needed if variable is protected 
    {
        return $"{_studentName}";
    }
}