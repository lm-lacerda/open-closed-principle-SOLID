// Below, there is an example of the break of the Open-Closed
// Principle. As it can be seen, for every new feature, like 
// the addition of a new type of filter, the class needs to 
// be modified.

using OpenClosedPrinciple.Domain;
using OpenClosedPrinciple.Domain.Enums;

namespace OpenClosedPrinciple.Filters;
public static class ProductFilter
{
    public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    {
        foreach (var product in products)
        {
            if (product.Size == size)
            {
                yield return product;
            }
        }
    }

    public static IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    {
        foreach (var product in products)
        {
            if (product.Color == color)
            {
                yield return product;
            }
        }
    }

    public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products,
        Size size, Color color)
    {
        foreach (var product in products)
        {
            if (product.Size == size && product.Color == color)
            {
                yield return product;
            }
        }
    }
}
