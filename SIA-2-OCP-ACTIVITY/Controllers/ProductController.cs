using Microsoft.AspNetCore.Mvc;
using SIA_2_OCP_ACTIVITY.Models;
using SIA_2_OCP_ACTIVITY.Repository;

namespace SIA_2_OCP_ACTIVITY.Controllers
{
    public class ProductController : Controller
    {
        private readonly Product[] _products;
        private readonly BetterFilter _filter;

        public ProductController()
        {
            // Sample products
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);
            _products = new[] { apple, tree, house };

            _filter = new BetterFilter();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GreenProducts()
        {
            var greenProducts = _filter.Filter(_products, new ColorSpecification(Color.Green));
            return View(greenProducts); // Passing filtered data to view
        }

        public IActionResult LargeProducts()
        {
            var largeProducts = _filter.Filter(_products, new SizeSpecification(Size.Large));
            return View(largeProducts); // Passing filtered data to view
        }

        public IActionResult LargeBlueProducts()
        {
            var largeBlueProducts = _filter.Filter(_products,
                new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))
            );
            return View(largeBlueProducts); // Passing filtered data to view
        }
    }
}
