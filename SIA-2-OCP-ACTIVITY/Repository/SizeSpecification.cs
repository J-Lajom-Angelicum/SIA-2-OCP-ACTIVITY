using SIA_2_OCP_ACTIVITY.Interfaces;
using SIA_2_OCP_ACTIVITY.Models.Data;

namespace SIA_2_OCP_ACTIVITY.Repository
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }
}
