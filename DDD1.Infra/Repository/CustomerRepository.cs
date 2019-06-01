using System;
using DDD1.Domain.Entities;
using DDD1.Domain.Repository;
using DDD1.Infra.Context;
using Dapper;

namespace DDD1.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDB _db;

        public CustomerRepository(IDB db)
        {
            _db = db;
        }

        public bool CpfExist(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            using (var db = _db.GetConnection())
            {
                var sql = "INSERT INTO Customer (Name, Address) VALUES (@Name, @Address)";
                db.Execute(sql, new { Name = customer.Name, Address = customer.Email.Address });
            }
        }

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
