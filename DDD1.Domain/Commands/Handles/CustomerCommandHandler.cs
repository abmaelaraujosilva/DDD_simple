using DDD1.Domain.Commands.Inputs;
using DDD1.Domain.Commands.Results;
using DDD1.Domain.Entities;
using DDD1.Domain.Repository;
using DDD1.Domain.ValuesObjects;
using DDD1.Shared.Commands;
using FluentValidator;

namespace DDD1.Domain.Commands.Handles
{
    public class CustomerCommandHandler : Notifiable, ICommandHandler<RegisterCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerCommandHandler(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public ICommandResult Handler(RegisterCustomerCommand command)
        {
            //1 - Criar VOs
            var email = new Email(command.Address);
            //2 - Criar Entities
            var customer = new Customer(command.Name, email);
            //3 - Adicionar Notifivations
            AddNotifications(customer.Notifications);
            AddNotifications(email.Notifications);
            //4 - Validations
            //if (customer.IsValid)
            //    return new RegisterCustomerCommandResult { Mensage = "Cliente invalido!" };
            //5 - Repository
            _customerRepository.Save(customer);
            //6 - Return
            return new RegisterCustomerCommandResult { Mensage = "Cliente salvo!" };
        }
    }
}
