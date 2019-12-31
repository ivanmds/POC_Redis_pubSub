using BeetleX.Redis;
using POCRedis.Contexts;
using POCRedis.Domain.Entities;
using System;

namespace POCRedis.Consumers
{
    public class PersonConsumer : ConsumerBase<Person>
    {
        protected override void Execute(object obj, SubscribeMessage message)
        {
            if (message.Type != SubscribeMessageType.Message) return;

            using var context = new MyContext();
            var person = message.Data as Person;

            if (person is null) return;

            person.Id = Guid.NewGuid();
            
            context.Persons.Add(person);
            context.SaveChanges();
        }
    }
}
