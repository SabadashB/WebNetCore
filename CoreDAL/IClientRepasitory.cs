using System;
using System.Collections.Generic;
using System.Text;

namespace CoreDAL
{
    interface IClientRepasitory
    {
        IEnumerable<Client> GetAll();
        Client GetById(Guid id);
        bool DeleteById(Guid id);
        bool Update(Client client);
        Guid Add(Client client);
    }
}
