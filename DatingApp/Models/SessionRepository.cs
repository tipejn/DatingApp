using DatingApp.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace DatingApp.Models
{
    public class SessionRepository : DatingRepository
    {
        public static DatingRepository GetDatingRepository(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionRepository repo = session?.GetJson<SessionRepository>("repo") ?? new SessionRepository();
            repo.Session = session;
            return repo;

        }
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddPerson(Person person)
        {
            base.AddPerson(person);
            Session.SetJson("repo", this);
        }
    }
}
