namespace FindProductsInPriceRange
{
    using Wintellect.PowerCollections;

    public class ProductStore
    {
        private OrderedBag<Product> products;

        public ProductStore()
        {
            this.Products = new OrderedBag<Product>();
        }

        public OrderedBag<Product> Products
        {
            get
            {
                return this.products;
            }
            set
            {
                this.products = value;
            }
        }

        public void AddProduct(Product product)
        {
            this.products.Add(product);
        }
    }
}
