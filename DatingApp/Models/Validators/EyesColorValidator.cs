namespace DatingApp.Models.Validators
{
    public class EyesColorValidator : IPersonValidator
    {
        public bool Matched(Person woman, Person man)
        {
            return man.EyesColor == woman.EyesColor;
        }
    }
}
