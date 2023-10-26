
class MathAssignment : Assignments  //derived or sub class
{
    private string _textBookSection;
    private string _problems;

    // constructor
    public MathAssignment(string studentName, string topic) : base(studentName, topic)
    {

    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }

}