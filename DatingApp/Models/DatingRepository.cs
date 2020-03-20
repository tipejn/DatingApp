using Newtonsoft.Json;
using System.Collections.Generic;

namespace DatingApp.Models
{
    public class DatingRepository
    {
        [JsonProperty]
        private Dictionary<Gender, Person> personCollection = new Dictionary<Gender, Person>();
        public virtual void AddPerson(Person person)
        {
            var key = person.Gender;
            if (personCollection.ContainsKey(key))
            {
                personCollection[key] = person;
            }
            else
            {
                personCollection.Add(key, person);
            }
        }
        public Person GetPerson(Gender gender)
        {
            return personCollection[gender];
        }
    }
}
