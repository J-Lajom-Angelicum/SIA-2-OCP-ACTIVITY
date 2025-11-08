using SIA_2_OCP_ACTIVITY.Interfaces;
using SIA_2_OCP_ACTIVITY.Models;

namespace SIA_2_OCP_ACTIVITY.Repository
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
                if (spec.IsSatisfied(i))
                    yield return i;
        }
    }
}
