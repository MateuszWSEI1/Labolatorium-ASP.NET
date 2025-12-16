using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_1.Models
{
    public class Reservation
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać datę rezerwacji")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Proszę podać miasto")]
        [StringLength(100, ErrorMessage = "Miasto może mieć maksymalnie 100 znaków")]
        public string City { get; set; }

        [Required(ErrorMessage = "Proszę podać adres")]
        [StringLength(200, ErrorMessage = "Adres może mieć maksymalnie 200 znaków")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Proszę podać pokój")]
        [StringLength(50, ErrorMessage = "Pokój może mieć maksymalnie 50 znaków")]
        public string Room { get; set; }

        [Required(ErrorMessage = "Proszę podać właściciela")]
        [StringLength(100, ErrorMessage = "Właściciel może mieć maksymalnie 100 znaków")]
        public string Owner { get; set; }

        [Required(ErrorMessage = "Proszę podać cenę")]
        [Range(1, 100000, ErrorMessage = "Cena musi mieścić się w zakresie 1–100000")]
        public decimal Price { get; set; }
    }
}