using OpenClosedPrinciple.Domain.Enums;

namespace OpenClosedPrinciple.Domain;
public class Product
{
    public string Name { get; set; } = string.Empty;
    public Color Color { get; set; }
    public Size Size { get; set; }

    public Product(string name, Color color, Size size)
    {
        Name = name;
        Color = color;
        Size = size;
    }
}
