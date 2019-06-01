using FluentValidator;

namespace DDD1.Domain.ValuesObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;
            new ValidationContract<Email>(this)
                .IsEmail(x=>x.Address, "Email é invalido");
                
        }

        public string Address { get; private set; }
    }
}
