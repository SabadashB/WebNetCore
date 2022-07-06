using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreDAL
{
    public class Client
    {
            [KeyAttribute]
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
    }
}
