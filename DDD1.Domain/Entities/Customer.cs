
using DDD1.Shared.Entities;
using DDD1.Domain.ValuesObjects;
using FluentValidator;

namespace DDD1.Domain.Entities
{
    public class Customer:Entity
    {
        public Customer(string name, Email email)
        {
            Name = name;
            Email = email;
            new ValidationContract<Customer>(this)
                .HasMinLenght(x=>x.Name, 3, "O digite no minimo 3 caracteres!");
        }

        public string Name { get; private set; }
        public Email Email { get; private set; }
    }
}
