using OpenClosedPrinciple.Specifications.Interfaces;

namespace OpenClosedPrinciple.Filters.Interfaces;
public interface IFilter<T>
{
    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
}
