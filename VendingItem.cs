namespace VendingMachineProject
{
    public class VendingItem
    {
        private string productName;
        private decimal price;
        private int itemsRemaining;
        private string message;

        public VendingItem(string productName, decimal price, int itemsRemaining, string message)
        {
            this.productName = productName;
            this.price = price;
            this.itemsRemaining = itemsRemaining;
            this.message = message;
        }

        public bool MessageWhenSoldOut { get; internal set; }
        public decimal Price { get; internal set; }
        public object MessageWhenVended { get; internal set; }
    }
}