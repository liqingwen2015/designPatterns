using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Sample1
{
    /// <summary>
    /// 抽象界面构件类：抽象构件类
    /// </summary>
    public abstract class Component
    {
        public abstract void Display();
    }

    /// <summary>
    /// 构件装饰类：抽象装饰类
    /// </summary>
    public class ComponentDecorator : Component
    {
        private readonly Component _component;

        public ComponentDecorator(Component component)
        {
            _component = component;
        }

        public override void Display()
        {
            _component.Display();

        }
    }
}
