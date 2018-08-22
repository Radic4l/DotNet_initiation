using System;

namespace ConsoleApp1
{
    internal class DateProvider : IDate
    {
        DateTime IDate.Time {
            get
            {
                return DateTime.Now;
            }
        }
    }
}