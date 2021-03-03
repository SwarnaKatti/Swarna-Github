using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
    class Program
    {
        public class VendingMachine
        {
            public Logger Log = new Logger();
            private Logger Log = new Logger();
            public Dictionary<string, VendingItem> VendingMachineItems = new Dictionary<string, VendingItem>();
            FileHandler HandleFiles = new FileHandler();
            public Money Money;
            private readonly Money money;

            public Money GetMoney()
            {
                return money;
            }

            public string NotEnoughMoneyError = "Not enough money in the machine to complete the transaction.";
            public string MessageToUser;

            public VendingMachine()
            {
                this.VendingMachineItems = this.HandleFiles.GetVendingItems();
                this.money = new Money(this.Log);

            }

            public decimal MoneyInMachine
            {
                get
                {
                    return this.GetMoney().MoneyInMachine;
                }
            }

            public void DisplayAllItems()
            {
                Console.WriteLine($"\n\n{"#".PadRight(5)} {"Stock"} { "Product".PadRight(47) } { "Price".PadLeft(7)}");
            }

            internal bool ItemExists(string choice)
            {
                throw new NotImplementedException();
            }

            internal bool RetreiveItem(string choice)
            {
                throw new NotImplementedException();
            }
        }
    }
}
            

