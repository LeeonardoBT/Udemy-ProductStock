using System.Globalization;

namespace ProductStock
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int QuantityStock { get; private set; }

        public Product(string name, double price, int quantityStock)
        {
            this._name = name;
            this.Price = price;
            this.QuantityStock = quantityStock;
        }

        public Product(string name, double price)
        {
            this._name = name;
            this.Price = price;
            this.QuantityStock = 0;
        }

        public string Name
        {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double StockValue()
        {
            return Price * QuantityStock;
        }

        public void AddStock(int quantity)
        {
            QuantityStock+= quantity;
        }

        public void RemoveStock(int quantity)
        {
            QuantityStock -= quantity;
        }

        public override string ToString()
        {
            return _name + ", $ " +
                   Price.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   QuantityStock + " unidades, total: $ " +
                   StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
