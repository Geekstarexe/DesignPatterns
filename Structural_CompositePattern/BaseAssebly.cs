using System.Collections.Generic;

namespace Structural_CompositePattern
{
    public abstract class BaseAssebly
    {
        protected string Name { get; set; }
        protected int Quantity { get; set; }

        public BaseAssebly(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public abstract void Add(BaseAssebly assembly);
        public abstract void Remove(BaseAssebly assembly);
        public abstract void WritePartsList(List<string> list);

    }
}