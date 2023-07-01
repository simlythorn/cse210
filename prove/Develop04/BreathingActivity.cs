using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    public void Run()
    {
        DisplayStartingMessage(_name, _description, _duration);
        int timeSpent = 0; 
        while(timeSpent < _duration)
        {
            //Console.Write("Breathe in...");
            List<string> AnimationBreaths = new List<string>();
                AnimationBreaths.Add("B");
                AnimationBreaths.Add("r");
                AnimationBreaths.Add("e");
                AnimationBreaths.Add("a");
                AnimationBreaths.Add("t");
                AnimationBreaths.Add("h");
                AnimationBreaths.Add("i");
                AnimationBreaths.Add("n");
                AnimationBreaths.Add("g");
                AnimationBreaths.Add(".");
                AnimationBreaths.Add(".");
                AnimationBreaths.Add(".");
                int sleepTime = 200;
                for (int i = 0; i < AnimationBreaths.Count; i++)
                {
                    string text = AnimationBreaths[i];
                    Console.Write(text);
                    Console.Write(" ");
                    Thread.Sleep(sleepTime);
                    Console.Write("\b \b");
                    sleepTime += 100;
                }

            ShowCountDown(4);
            Console.WriteLine(" ");
            //Console.Write("Breathe out...");
            List<string> AnimationBreathout = new List<string>();
                AnimationBreathout.Add("B");
                AnimationBreathout.Add("r");
                AnimationBreathout.Add("e");
                AnimationBreathout.Add("a");
                AnimationBreathout.Add("t");
                AnimationBreathout.Add("h");
                AnimationBreathout.Add("i");
                AnimationBreathout.Add("n");
                AnimationBreathout.Add("g");
                AnimationBreathout.Add(".");
                AnimationBreathout.Add(".");
                AnimationBreathout.Add(".");
                int sleepTimeOut = 200;
                for (int i = 0; i < AnimationBreathout.Count; i++)
                {
                    string text = AnimationBreathout[i];
                    Console.Write(text);
                    Console.Write(" ");
                    Thread.Sleep(sleepTimeOut);
                    Console.Write("\b \b");
                    sleepTimeOut += 100;
                }
            ShowCountDown(6);
            Console.WriteLine(" ");
            timeSpent += 10;
            Console.WriteLine(" ");
        }

        ShowProgressBar(2);
        DisplayEndingMessage(_name, _description, _duration); 
    }

}