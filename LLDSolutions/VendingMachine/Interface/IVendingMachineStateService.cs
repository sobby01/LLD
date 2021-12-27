using LLDSolutions.VendingMachine.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.VendingMachine.Interface
{
    public interface IVendingMachineStateService
    {
        public int GetPrice(Product item);

        //There can be payment service like :  paytm, razorpay
        public void AddMoney(Coin money);
        public List<Coin> GetRefund();
        public Tuple<Product, List<Coin>> GetItemAndReturnMoney();

    }
}
