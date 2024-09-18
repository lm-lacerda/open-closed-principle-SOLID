// DEFINITION: Objects or entities should be open for extension but 
// closed for modification.

// For a better understandment of the principle application, it's 
// needed to first view the contents of the "ProdutFilter" class 
// and then, proceeds to view the application of the Specification 
// Pattern used to prevent the break of the Open-Closed Principle. 
// Go first to the "ISpecification" and "IFilter" interfaces and 
// then, go to its implementations, and by last, view the contents 
// of the "Program" class, right below:

using OpenClosedPrinciple.Domain;
using OpenClosedPrinciple.Domain.Enums;
using OpenClosedPrinciple.Filters;
using OpenClosedPrinciple.Specifications;

var apple = new Product("Apple", Color.Green, Size.Small);
var tree = new Product("Tree", Color.Green, Size.Large);
var house = new Product("House", Color.Blue, Size.Large);

Product[] products = { apple, tree, house };

Console.WriteLine("Green Products (old):");
foreach (var product in ProductFilter.FilterByColor(products, Color.Green))
{
    Console.WriteLine($" - {product.Name} is green.");
}

var bf = new BetterFilter();

Console.WriteLine("Green products (new):");
foreach (var product in bf.Filter(products, new ColorSpecification(Color.Green)))
{
    Console.WriteLine($" - {product.Name} is green.");
}

Console.WriteLine("Large blue items:");
foreach (var product in bf.Filter(products,
    new AndSpecification<Product>
    (
        new SizeSpecification(Size.Large),
        new ColorSpecification(Color.Blue)
    )))
{
    Console.WriteLine($" - {product.Name} is large and blue.");
}
