using System;

namespace DatingApp.Models
{
    public class Person
    {
        public string Name { get; set; }
        public double Height { get; set; }
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
        Blue,
        Green,
        Brown
    }
}
