using DDD1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD1.Domain.Repository
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        void Update(Customer customer);
        bool CpfExist(Guid Id);
    }
}
