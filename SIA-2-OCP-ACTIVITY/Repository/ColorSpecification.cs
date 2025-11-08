using SIA_2_OCP_ACTIVITY.Interfaces;
using SIA_2_OCP_ACTIVITY.Models;

namespace SIA_2_OCP_ACTIVITY.Repository
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Color == color;
        }
    }
}
