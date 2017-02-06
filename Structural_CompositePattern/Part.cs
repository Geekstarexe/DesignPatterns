using System;
using System.Collections.Generic;

namespace Structural_CompositePattern
{
    public class Part : BaseAssebly
    {
        public Part(string name, int quantity) : base(name, quantity)
        {
        }

        public override void Add(BaseAssebly assembly)
        {
            throw new Exception("This is a part you can not add sub parts");
        }

        public override void Remove(BaseAssebly assembly)
        {
            throw new Exception("This is a part you can't remove anything");
        }

        public override void WritePartsList(List<string> list)
        {
            list.Add(Quantity.ToString() + " - " + Name);
        }
    }
}