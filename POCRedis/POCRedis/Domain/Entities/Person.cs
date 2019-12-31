using System;
using System.ComponentModel.DataAnnotations;

namespace POCRedis.Domain.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
    }
}
