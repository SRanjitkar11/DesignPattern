using System.ComponentModel.DataAnnotations;

namespace InshareDesignPattern
{
    public abstract class Components
    {
        protected int Id { get; set; }
        protected string Name { get; set; }

        public Components(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public abstract void Add(Components c);
        public abstract void Remove(Components c);
        public abstract void Dsiplay(int indent);
    }
}
