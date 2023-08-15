using System;

public delegate void ValueHandler(string msg);

public class Sender
{
    public int I { get; set; }
    //The Sender class can send these 2 events
    public event ValueHandler Low;
    public event ValueHandler High;

    public void ReadData()
    {
        I = int.Parse(Console.ReadLine());
        if (I < 1)
        {
            if (Low != null)
            {
                Low("Out of Range, Number is too small");
            }
        }
        else if (I > 100)
        {
            if (High != null)
            {
                High("Out of Range, Number is too large");
            }
        }
    }//End Read Data
}//End Sender Class

//The Listening to the incoming Event
public class EventApp
{
    public static int Main()
    {
        Sender s = new Sender();
        //Hooks into events
        s.Low += new ValueHandler(OnLow);
        s.High += new ValueHandler(OnHigh);
        //Call the Read Data
        s.ReadData();
        return 0;
    }

    public static void OnLow(string str)
    {
        Console.WriteLine($"{str}");
    }

    public static void OnHigh(string str)
    {
        Console.WriteLine($"{str}");
    }
}
