using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_1.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Imię")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proszę podać email!")]
        [EmailAddress(ErrorMessage = "Proszę podać poprawny email!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Priorytet")]
        public Priority Priority { get; set; }

        [HiddenInput]
        public int Id { get; set; }

        [HiddenInput]
        public DateTime Created { get; set; }
    }
}