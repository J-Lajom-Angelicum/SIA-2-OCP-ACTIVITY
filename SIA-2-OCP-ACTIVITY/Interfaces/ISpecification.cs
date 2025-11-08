using SIA_2_OCP_ACTIVITY.Models;

namespace SIA_2_OCP_ACTIVITY.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
