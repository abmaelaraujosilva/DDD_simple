using DDD1.Shared.Commands;

namespace DDD1.Domain.Commands.Inputs
{
    public class RegisterCustomerCommand : ICommand
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
