using LLDSolutions.VendingMachine.Interface;
using LLDSolutions.VendingMachine.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.VendingMachine.Services
{
    public class ReadyState : IVendingMachineStateService
    {
        public void AddMoney(Coin money)
        {
            throw new NotImplementedException();
        }

        public Tuple<Product, List<Coin>> GetItemAndReturnMoney()
        {
            throw new NotImplementedException();
        }

        public int GetPrice(Product item)
        {
            throw new NotImplementedException();
        }

        public List<Coin> GetRefund()
        {
            throw new NotImplementedException();
        }
    }
}
