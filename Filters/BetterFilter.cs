// This version of filter don't break the Open-Closed Principle, and
// is naturally closed for modifications on itself (as they aren't 
// needed) and open for extension, made possible by the use of 
// abstraction by interfaces.

using OpenClosedPrinciple.Domain;
using OpenClosedPrinciple.Filters.Interfaces;
using OpenClosedPrinciple.Specifications.Interfaces;

namespace OpenClosedPrinciple.Filters;
public class BetterFilter : IFilter<Product>
{
    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
    {
        foreach (var item in items)
        {
            if (spec.IsSatisfied(item))
            {
                yield return item;
            }
        }
    }
}
