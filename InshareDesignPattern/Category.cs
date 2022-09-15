namespace InshareDesignPattern
{
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
