namespace DatingApp.Models.Validators
{
    public class HeightValidator : IPersonValidator
    {
        private int minDiff = 10;
        public bool Matched(Person woman, Person man)
        {
            return ((int)(man.Height * 100) - (int)(woman.Height * 100)) >= minDiff;
        }
    }
}
