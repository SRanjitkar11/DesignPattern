namespace InshareDesignPattern
{
    public class Attributes : AttributeComponents
    {
        List<Components> attributes = new List<Components>();

        public int GetId()
        {
            return this.Id;
        }

        public Attributes(int id, string name, string dataType, string value) : base(id, name, dataType, value)
        {
            this.Id = id;
        }

        public override void Add(Components a)
        {
            attributes.Add(a);
        }

        public override void Dsiplay(int indent)
        {
            Console.WriteLine(new string(' ', indent) + "* Attribute: " + Name + ": " + DataTypes);
            Console.WriteLine(new string(' ', indent +2 ) + "* Values: " + Value);

        }

        public override void Remove(Components a)
        {
            attributes.Remove(a);
        }
    }
}
