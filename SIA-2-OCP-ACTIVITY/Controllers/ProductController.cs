using Microsoft.AspNetCore.Mvc;
using SIA_2_OCP_ACTIVITY.Models;
using SIA_2_OCP_ACTIVITY.Repository;  // Adjusted to the correct namespace

namespace SIA_2_OCP_ACTIVITY.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _repository;
        private readonly BetterFilter _filter;

        // Constructor now initializes the repository and filter
        public ProductController()
        {
            _repository = new ProductRepository();  // Using the repository to get products
            _filter = new BetterFilter();
        }

        // Index - Display all products
        public IActionResult Index()
        {
            var products = _repository.GetAllProducts();  // Get all products from the repository
            return View(products);
        }

        // GreenProducts - Filter for green products
        public IActionResult GreenProducts()
        {
            var greenProducts = _filter.Filter(_repository.GetAllProducts(), new ColorSpecification(Color.Green));
            return View(greenProducts);  // Passing filtered data to the view
        }

        // LargeProducts - Filter for large products
        public IActionResult LargeProducts()
        {
            var largeProducts = _filter.Filter(_repository.GetAllProducts(), new SizeSpecification(Size.Large));
            return View(largeProducts);  // Passing filtered data to the view
        }

        // LargeBlueProducts - Filter for large blue products
        public IActionResult LargeBlueProducts()
        {
            var largeBlueProducts = _filter.Filter(
                _repository.GetAllProducts(),
                new AndSpecification<Product>(
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
                )
            );
            return View(largeBlueProducts);  // Passing filtered data to the view
        }

        // Add - Action for adding a new product
        [HttpPost]
        public IActionResult Add(ProductAddDTO productAddDTO)
        {
            if (ModelState.IsValid)
            {
                // Create a new product from the DTO and add it to the repository
                var product = new Product(productAddDTO.Name, productAddDTO.Color, productAddDTO.Size);
                _repository.AddProduct(product);
                return RedirectToAction("Index");
            }

            // Return the DTO to the view if model validation fails
            return View(productAddDTO);
        }

        // Add - GET method to display the product creation form
        public IActionResult Add()
        {
            return View();
        }
    }
}
