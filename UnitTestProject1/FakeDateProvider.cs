using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    internal class FakeDateProvider : IDate
    {
        public DateTime Time {
            get; set;
        }

        public FakeDateProvider(DateTime date)
        {
            this.Time = date;
        }

    }
}