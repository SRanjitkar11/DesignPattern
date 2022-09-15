using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InshareDesignPattern
{
    public interface IComponent
    {
        int Id { get; set; }
        string Name { get; set; }
        void Add();
        void Remove();
        void Display();
    }


    public interface IComponentWithDataType
    {
        string DataType { get; set; }
    }


    public class Component : IComponent
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }


    public class AttrComponent : IComponent, IComponentWithDataType
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DataType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
