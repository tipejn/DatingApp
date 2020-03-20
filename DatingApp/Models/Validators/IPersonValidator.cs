namespace DatingApp.Models.Validators
{
    public interface IPersonValidator
    {
        bool Matched(Person woman, Person man);
    }
}
