using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _questionList = new List<string>()
    {
        "What are you grateful for today?",
        "Write 5 affirmations for when you are feeling low.",
        "What is the best book you have read recently?",
        "What are your plans for this weekend?",
        "How have you grown this week?",
        "Name the three biggest priorities in your life right now.",
        "Do you have a fear that is stopping you from achieving your goals?",
        "Name three challenges…. and three ways to overcome them.",
        "Name three bad habits you would like to change.",
        "Add some more items to your bucket list…if you do not have a bucket list, start one.",
        "What is your biggest regret?",
        "List the best 10 moments of your life so far.",
        "Share a memory of your childhood.",
        "What did you do today?",
        "How did you serve others this week?",
    };

    public string GetRandomQuestion()
    {
        return _questionList[0];
        // generates a random question
    }
}