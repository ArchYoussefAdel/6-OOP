using System;

public delegate void ValueHandler(string massage);

public class Sender
{
    public int I { get; set; }
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
    }
}

public class EventApp
{
    public static int Main()
    {
        Sender s = new Sender();
        s.Low += new ValueHandler(OnLow);
        s.High += new ValueHandler(OnHigh);
        s.ReadData();
        return 0;
    }

    public static void OnLow(string massage)
    {
        Console.WriteLine($"{massage}");
    }

    public static void OnHigh(string massage)
    {
        Console.WriteLine($"{massage}");
    }
}
