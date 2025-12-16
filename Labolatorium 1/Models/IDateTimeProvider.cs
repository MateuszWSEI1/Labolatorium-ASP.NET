using System;

namespace Labolatorium_1.Models
{
    public interface IDateTimeProvider
    {
        DateTime GetCurrentDateTime();
    }
}