using System.Collections.Generic;

namespace Structural_CompositePattern
{
    public class Assembly : BaseAssebly
    {
        private  List<BaseAssebly> Elements = new List<BaseAssebly>();

        public Assembly(string name, int quantity) : base(name, quantity)
        {
        }

        public override void Add(BaseAssebly assembly)
        {
            Elements.Add(assembly);
        }

        public override void Remove(BaseAssebly assembly)
        {
            Elements.Remove(assembly);
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(Quantity.ToString() + " - " + Name);

            foreach (BaseAssebly assebly in Elements)
            {
                assebly.WritePartsList(list);
            }
        }
    }
}