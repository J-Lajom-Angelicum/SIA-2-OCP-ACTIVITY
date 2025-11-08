using SIA_2_OCP_ACTIVITY.Models;

namespace SIA_2_OCP_ACTIVITY.Repository
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>();

        public ProductRepository()
        {
            // Sample products
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            _products = new List<Product> { apple, tree, house };
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
