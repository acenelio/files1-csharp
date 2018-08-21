namespace Course.Entities {
    class Product {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity) {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total() {
            return Price * Quantity;
        }
    }
}
