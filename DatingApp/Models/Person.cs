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
        [Required]
        [Range(0.5, 5, ErrorMessage = "Proszę podać prawidłową wartość")]
        public double Height { get; set; }
        [Required(ErrorMessage = "Proszę podać datę urodzin w formacie rrrr-mm-dd")]
        [UIHint("Date")]
        [MustBeAdult(ErrorMessage = "Osoba musi być pełnoletnia")]
        public DateTime BirthDate { get; set; }
        [Required]
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
