class Activity // base or super class
{
    private string _name;
    private string _description;
    private int _durationPauseTime = 0;
    private int _duration = 0;


    /*public string _activity;
    public int _userchoice;
    public int _time;*/

    //constructor
    public Activity()
    {
        _name = "name";
        _description = "The Mindfulness Program";
        _durationPauseTime = 0;
        _duration = 0;
    }
    public Activity(string name, string description, int durationPauseTime, int duration)
    {
        _name = name;
        _description = description;
        _durationPauseTime = durationPauseTime;
        _duration = duration;
    }

    public string GetName() //method
    {
        return $"{_name} ";
    }

    public string GetDescription() //method
    {
        return $"{_description} ";
    }

    public string GetDurationPauseTime() //method
    {
        return $"{_durationPauseTime} ";
    }

    public string GetDuration() //method
    {
        return $"{_duration} ";
    }

}
/*
*****Working with Time****
The C# language has a powerful Date and Time library. You might find it useful to get the current time, 
add a number of seconds to it, and then check if the current time is less than the new time.

This can be accomplished with the DateTime class. An object with the current time can be obtained withe DateTime.Now . 
Then, it has methods such as .AddSeconds(numberOfSeconds), and it works with the less than < operator as you would expect.

The following code snippet shows an example:

}DateTime startTime = DateTime.Now;
DateTime futureTime = startTime.AddSeconds(5);

Thread.Sleep(3000);

DateTime currentTime = DateTime.Now;
if (currentTime < futureTime)
{
    Console.WriteLine("We have not arrived at our future time yet...")
*/


/*
****Display Animations***
To display an animation, such as the spinner or the countdown timer, you need to have the computer pause for a period of time, and then replace the previous character with a new one. This can be done by writing the backspace character "\b" and which works like pushing the left arrow. Then, you can write a new character over the top of it.

Because the backspace character works like pressing the left arrow, instead of a backspace, it does not delete the character on the screen. With this in mind, it is common to write "\b \b" which moves left, writes a blank space over the previous character and then moves left again so it is ready for your new character.

The following example shows how to overwrite a character after half a second:


Console.Write("+");

Thread.Sleep(500);

Console.Write("\b \b"); // Erase the + character
Console.Write("-"); // Replace it with the - character

If this code were in a loop it would continue displaying and replacing characters.
*/


/*
*****Pausing****
In the demo video, you can see the program pausing for a certain period of time. This can be done with the Thread.Sleep() method which takes an integer as the number of milliseconds for the current "thread of execution" to sleep or pause.

The following example shows how to make the computer to wait for 1 second (1000 milliseconds):


Console.WriteLine("Going to sleep for a second...");

Thread.Sleep(1000);

Console.WriteLine("I'm back!!");
*/