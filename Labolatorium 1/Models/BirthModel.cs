using System;

namespace Labolatorium_1.Models
{
    public class Birth
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) && BirthDate.HasValue && BirthDate.Value.Date < DateTime.Today;
        }

        public int GetAge()
        {
            if (!BirthDate.HasValue) return 0;

            var today = DateTime.Today;
            int age = today.Year - BirthDate.Value.Year;

            if (BirthDate.Value.Date > today.AddYears(-age))
                age--;

            return age;
        }
    }
}