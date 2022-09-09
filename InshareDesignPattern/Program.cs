using InshareDesignPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Category category1 = new Category(1, "Test Category");
        Element element1 = new Element(1, "Test Element");
        Attributes attributes1 = new Attributes(1, "Name", "string");
        Attributes attributes2 = new Attributes(2, "Date", "Date");
        Attributes attributes3 = new Attributes(3, "Price", "Decimal");
        AttributesValue attributesValue1 = new AttributesValue(1, "test1");
        AttributesValue attributesValue2 = new AttributesValue(2, "Date");
        category1.Add(element1);
        element1.Add(attributes1);
        attributes1.Add(attributesValue1);
        element1.Add(attributes2);
        attributes2.Add(attributesValue2);
        element1.Add(attributes3);
        category1.Add(new Element(2, "Element 2"));
        category1.Dsiplay(0);

        Console.WriteLine();

        Category category2 = new Category(2, "Ball");
        category2.Add(new Element(1, "Radius"));
        category2.Add(new Element(2, "Weight"));
        category2.Dsiplay(0);

        Console.WriteLine();

        AttributeValue attribute;
        Builder builder = new Builder();
        attribute = new Customer1();
        builder.Construct(attribute);
        attribute.Attribute.Show();

        Console.WriteLine();
        
        attribute = new Customer2();
        builder.Construct(attribute);
        attribute.Attribute.Show();

        Console.ReadKey();
    }
}
