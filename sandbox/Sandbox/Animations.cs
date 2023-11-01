using System;

class Animations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        /* This is a long hand write up but can Make into a loop!
        Console.WriteLine(5);
        Thread.Sleep(1000);
        Console.WriteLine(4);
        Thread.Sleep(1000);
        Console.WriteLine(3);
        Thread.Sleep(1000);
        Console.WriteLine(2);
        Thread.Sleep(1000);
        Console.WriteLine(1);
        Thread.Sleep(1000);
        */


        /* This is the Loop with 1 second intervals between numbers.
        For (int i = 5; i > 0; i--)
        {
        Console.WriteLine(i);  // Change to Console.Write() to have the numbers stay on the same line like.. 54321
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
        */


        /*This is for a dotted "...." Animation
        For (int i = 5; i > 0; i--)
        {
            Console.WriteLine("."); 
            Thread.Sleep(1000);
        //  Console.Write("\b \b");  //not needed
        }
        */


        /*This is for a spinning bar animation "|/-\|/-\|"
        List<string> animationStrings = new List<string>();
        AnimationStrings.Add("|");
        AnimationStrings.Add("/");
        AnimationStrings.Add("-");
        AnimationStrings.Add("\\");
        AnimationStrings.Add("|");
        AnimationStrings.Add("/");
        AnimationStrings.Add("-");
        AnimationStrings.Add("\\");

         Foreach (string s in animationsString)
        {
            Console.WriteLine(s); 
            Thread.Sleep(1000);
            Console.Write("\b \b");
        } 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10); 

        While (DateTime.Now <endTime)
        {
            Console.WriteLine("."); 
            Thread.Sleep(1000);
        }

        // OR USE a more complex way and looks better!!  

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10); 
    
        int i = 0;

        While (DateTime.Now <endTime)
       {
            String s = animationStrings[i];
            Console.WriteLine(s); 
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        } 
        
        */

        Console.WriteLine("Done.");
    }
}