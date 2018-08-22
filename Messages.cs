using System;



public class Messages
{
	public HelloMessages()
	{
        string hello = "";

        if (Mydate.DayOfWeek == DayOfWeek.Saturday
            || Mydate.DayOfWeek == DayOfWeek.Sunday
            || (Mydate.DayOfWeek == DayOfWeek.Monday && Mydate.Hour < 9)
            || (Mydate.DayOfWeek == DayOfWeek.Friday && Mydate.Hour >= 19))
        {
            hello = "Bon Week-End";
        }
        else
        {
            if (Mydate.Hour >= 9)
            {
                if (Mydate.Hour >= 18)
                {
                    hello = "Bonsoir ";
                }
                else if (Mydate.Hour >= 13)
                {
                    hello = "Bon après-midi ";
                }
                else
                {
                    hello = "Bonjour ";
                }
            }
            else
            {
                hello = "Bonsoir ";
            }
        }
    }
}
