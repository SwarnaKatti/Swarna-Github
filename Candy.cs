using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject
{
    class Candy : VendingItem
    {

        public const string Message = "Munch, Munch, Yum!";

        public Candy(
            string productName,
            decimal price,
            int itemsRemaining)
                : base(
                productName,
                price,
                itemsRemaining,
                Message)
        {
        }
    }
}
}
