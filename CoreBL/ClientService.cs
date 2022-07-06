using CoreDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBL
{
    public class ClientService : IClientService
    {
        public bool RentABooks(Book book, Client client)
        {
            throw new NotImplementedException();
        }

        public bool ReturnABooks(Book book, Client client)
        {
            throw new NotImplementedException();
        }

        public int PayForDamage(int price)
        {
            return price;
        }

        public int PayForDelay(int price)
        {
            return price;
        }

        public int PayForLost(int price)
        {
            return price;
        }

        public int PayForService(int price)
        {
            return price;
        }
    }
}
