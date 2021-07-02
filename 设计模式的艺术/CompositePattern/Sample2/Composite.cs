using System.Collections.Generic;

namespace CompositePattern.Sample2
{
    public class Composite : Component
    {
        private readonly List<Component> _list = new List<Component>();

        public override void Add(Component c)
        {
            _list.Add(c);
        }

        public override void Remove(Component c)
        {
            _list.Remove(c);
        }

        public override Component GetChild(int i)
        {
            return (Component)_list[i];
        }

        public override void Operation()
        {
            // 容器构建具体业务方法的实现
            // 递归调用成员构件的业务方法
            foreach (var component in _list)
            {
                component.Operation();
            }
        }
    }
}