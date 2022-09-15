namespace InshareDesignPattern
{
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
}
