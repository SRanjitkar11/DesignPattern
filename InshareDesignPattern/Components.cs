namespace InshareDesignPattern
{
    public abstract class Components
    {
        protected int Id;
        protected string Name;

        public Components(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract void Add(Components c);
        public abstract void Remove(Components c);
        public abstract void Dsiplay(int indent);
    }

    public abstract class AttributeComponents : Components
    {
        protected string DataType;
        public AttributeComponents(int id, string name, string dataType) : base(id, name)
        {
            this.DataType = dataType;
        }
    }


    public class AttributesValue : Components
    {
        Components values;
        public AttributesValue(int id, string value) : base(id, value)
        {
        }

        public override void Add(Components c)
        {
            values.Add(c);
        }

        public override void Dsiplay(int indent)
        {
            Console.WriteLine(new String(' ', indent)+ "- Value: " + Name); 
        }

        public override void Remove(Components c)
        {
            values.Remove(c);
        }
    }

    class Attributes : AttributeComponents
    {
        List<Components> attributes = new List<Components>();

        public Attributes(int id, string name, string dataType) : base(id, name, dataType)
        {

        }
        public override void Add(Components a)
        {
            attributes.Add(a);
        }

        public override void Dsiplay(int indent)
        {
            Console.WriteLine(new string(' ', indent) + "* Attribute: " + Name + ": " + DataType);
            foreach (Components c in attributes)
            {
                c.Dsiplay(indent + 2);
            }
        }

        public override void Remove(Components a)
        {
            attributes.Remove(a);
        }
    }

    public class Element : Components
    {
        List<Components> elements = new List<Components>();
        public Element(int id, string name) : base(id, name)
        {

        }
        public override void Add(Components c)
        {
            elements.Add(c);
        }

        public override void Dsiplay(int indent)
        {
            Console.WriteLine(new string(' ', indent) + "- Element: " + Name);
            foreach (Components c in elements)
            {
                c.Dsiplay(indent + 2);
            }
        }

        public override void Remove(Components c)
        {
            elements.Remove(c);
        }
    }

    public class Category : Components
    {
        List<Components> category = new List<Components>();
        public Category(int id, string name) : base(id, name)
        {

        }
        public override void Add(Components c)
        {
            category.Add(c);
        }

        public override void Dsiplay(int indent)
        {
            Console.WriteLine(new string(' ', indent) + "+ Category:" + Name);
            foreach (Components c in category)
            {
                c.Dsiplay(indent + 2);
            }
        }

        public override void Remove(Components c)
        {
            category.Remove(c);
        }
    }
}
