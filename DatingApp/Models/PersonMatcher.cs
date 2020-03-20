using DatingApp.Models.Validators;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp.Models
{
    public class PersonMatcher
    {
        private List<IPersonValidator> validators = new List<IPersonValidator> { new AgeValidator(), new EyesColorValidator(), new HeightValidator() };
        public Person Woman { get; set; }
        public Person Man { get; set; }

        public bool Matched()
        {
            return validators.All(v => v.Matched(Woman, Man));
        }

    }
}
