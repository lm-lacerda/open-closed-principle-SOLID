using OpenClosedPrinciple.Domain;
using OpenClosedPrinciple.Domain.Enums;
using OpenClosedPrinciple.Specifications.Interfaces;

namespace OpenClosedPrinciple.Specifications;
public class SizeSpecification : ISpecification<Product>
{
    private Size _size;

    public SizeSpecification(Size size)
    {
        _size = size;
    }

    public bool IsSatisfied(Product product)
    {
        return product.Size == _size;
    }
}
