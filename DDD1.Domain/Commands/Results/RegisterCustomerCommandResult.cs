using DDD1.Domain.Entities;
using DDD1.Shared.Commands;
using System.Collections.Generic;

namespace DDD1.Domain.Commands.Results
{
    public class RegisterCustomerCommandResult : ICommandResult
    {
        public string Mensage { get; set; }
    }
}
