using DatingApp.Models.Validators;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp.Models
{
    public class PersonMatcher
    {
        private IEnumerable<IPersonValidator> validators;
        public Person Woman { get; set; }
        public Person Man { get; set; }

        public PersonMatcher(IEnumerable<IPersonValidator> validators)
        {
            this.validators = validators;
        }

        public bool Matched()
        {
            return validators.All(v => v.Matched(Woman, Man));
        }

    }
}
