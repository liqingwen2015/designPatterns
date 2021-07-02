using System;

namespace CompositePattern.Sample2
{
    public class Leaf : Component
    {
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }

        public override Component GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public override void Operation()
        {
            throw new NotImplementedException();
        }
    }
}