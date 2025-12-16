using System;

namespace Labolatorium_1.Models
{
    public class CurrentDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }
    }
}