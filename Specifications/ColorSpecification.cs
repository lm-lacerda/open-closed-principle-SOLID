using OpenClosedPrinciple.Domain;
using OpenClosedPrinciple.Domain.Enums;
using OpenClosedPrinciple.Specifications.Interfaces;

namespace OpenClosedPrinciple.Specifications;
public class ColorSpecification : ISpecification<Product>
{
    private Color _color;

    public ColorSpecification(Color color)
    {
        _color = color;
    }

    public bool IsSatisfied(Product product)
    {
        return product.Color == _color;
    }
}
