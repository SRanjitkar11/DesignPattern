namespace InshareDesignPattern
{
    public class Builder
    {
        public void Construct(AttributeValue attributeValue)
        {
            attributeValue.BuildName();
            attributeValue.BuildDataType();
            attributeValue.BuildValue();
        }
    }

    public abstract class AttributeValue
    {
        protected Attribute attribute;

        public Attribute Attribute
        {
            get { return attribute; }
        }

        public abstract void BuildName();
        public abstract void BuildDataType();
        public abstract void BuildValue();
    }

    public class Customer1 : AttributeValue
    {
        public Customer1()
        {
            attribute = new Attribute(1);
        }
        public override void BuildDataType()
        {
            attribute["DataType"] = "string";
        }

        public override void BuildName()
        {
            attribute["Name"] = "FullName";
        }

        public override void BuildValue()
        {
            attribute["Value"] = "Suneer ranjitkar";
        }
    }

    public class Customer2 : AttributeValue
    {
        public Customer2()
        {
            attribute = new Attribute(2);
        }
        public override void BuildDataType()
        {
            attribute["DataType"] = "string";
        }

        public override void BuildName()
        {
            attribute["Name"] = "Name";
        }

        public override void BuildValue()
        {
            attribute["Value"] = "Suneer";
        }
    }

    public class Attribute
    {
        private int _id;

        private Dictionary<string, string> _title = new Dictionary<string, string>();

        public Attribute(int id)
        {
            this._id = id;
        }

        public string this[string key]
        {
            get { return _title[key]; }
            set { _title[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("Id : {0}", _id);
            Console.WriteLine("Name : {0}", _title["Name"]);
            Console.WriteLine("Data Type : {0}", _title["DataType"]);
            Console.WriteLine("Value : {0}", _title["Value"]);
        }
    }
}