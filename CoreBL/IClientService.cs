using CoreDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreBL
{
    public interface IClientService
    {
        bool RentABooks(Book book, Client client);
        bool ReturnABooks(Book book, Client client);
        int PayForService(int price);
        int PayForLost(int price);
        int PayForDamage(int price);
        int PayForDelay(int price);


    }
}
