// Specification pattern: Dictates if a product satisfies some 
// particular criteria.

namespace OpenClosedPrinciple.Specifications.Interfaces;
public interface ISpecification<T>
{
    bool IsSatisfied(T t);
}
