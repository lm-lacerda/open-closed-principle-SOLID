// This is called a "combinator", and its purpose is to combine two 
// specifications into one.

using OpenClosedPrinciple.Specifications.Interfaces;

namespace OpenClosedPrinciple.Specifications;
public class AndSpecification<T> : ISpecification<T>
{
    private ISpecification<T> _first, _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }

    public bool IsSatisfied(T t)
    {
        return _first.IsSatisfied(t) && _second.IsSatisfied(t);
    }
}
