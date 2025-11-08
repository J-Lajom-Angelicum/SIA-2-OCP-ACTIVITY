using System.Net.Http.Headers;

namespace SIA_2_OCP_ACTIVITY.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p)
    }
}
