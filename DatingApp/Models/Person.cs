using DatingApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Proszę podać imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać prawidłową wartość")]
        [Range(0.1, 4, ErrorMessage = "Proszę podać wartość między 0.1 a 4")]
        public double Height { get; set; }
        [Required]
        [UIHint("Date")]
        [MustBeAdult(ErrorMessage = "Osoba musi być pełnoletnia")]
        public DateTime BirthDate { get; set; }
        public EyesColor EyesColor { get; set; }
        public Gender Gender { get; set; }
    }

    public enum Gender
    {
        Female,
        Male
    }

    public enum EyesColor
    {
        [Display(Name = "niebieskie")]
        Blue,
        [Display(Name = "zielone")]
        Green,
        [Display(Name = "piwne")]
        Brown
    }
}
