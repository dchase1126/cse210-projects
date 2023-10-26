class WritingAssignment : Assignments
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // return $"{_title} by {_studentName}";   // To be used if variable in the base is protected
        return $"{_title} by {GetStudentName()}";  // To be used if Variable in base is private
    }

}