using System;


namespace ConsoleApp1
{
    



    public class Messages
    {
        private int Hmatin;
        private int Hmidi;
        private int Hsoir;
        private IDate DateProvider;

        public Messages(int matin, int midi, int soir)
            :this(new DateProvider(), matin, midi, soir)
        {
        }

        internal Messages(IDate dateProvider,int matin, int midi, int soir)
        {
            DateProvider = dateProvider;
            Hmatin = matin;
            Hmidi = midi;
            Hsoir = soir;
        }

        public string HelloMessages()
	    {
            DateTime Mydate = DateProvider.Time;
            string hello = "";

            if (Mydate.DayOfWeek == DayOfWeek.Saturday
                || Mydate.DayOfWeek == DayOfWeek.Sunday
                || (Mydate.DayOfWeek == DayOfWeek.Monday && Mydate.Hour < Hmatin)
                || (Mydate.DayOfWeek == DayOfWeek.Friday && Mydate.Hour >= Hsoir))
            {
                hello = "Bon Week-End";
            }
            else
            {
                if (Mydate.Hour >= Hmatin)
                {
                    if (Mydate.Hour >= Hsoir)
                    {
                        hello = "Bonsoir ";
                    }
                    else if (Mydate.Hour >= Hmidi)
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
            return hello;
        }
    }
}
