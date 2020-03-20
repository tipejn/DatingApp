namespace DatingApp.Models.Validators
{
    public class HeightValidator : IPersonValidator
    {
        private double minDiff = 0.10;
        public bool Matched(Person woman, Person man)
        {
            return (man.Height - woman.Height) >= minDiff;
        }
    }
}
