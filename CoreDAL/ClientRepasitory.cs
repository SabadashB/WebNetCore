using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreDAL
{
    class ClientRepasitory : IClientRepasitory
    {
        private readonly EFCoreDbContext _dbContext;
        public ClientRepasitory(EFCoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Guid Add(Client client)
        {
            client.Id = Guid.NewGuid();
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();

            return client.Id;
        }

        public bool DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetAll()
        {
            return _dbContext.Clients.ToList();
        }

        public Client GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
