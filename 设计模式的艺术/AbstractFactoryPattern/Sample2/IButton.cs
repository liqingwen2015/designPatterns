using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Sample2
{
    /// <summary>
    /// 按钮接口：抽象产品
    /// </summary>
    public interface IButton
    {
        void Display();
    }

    /// <summary>
    /// Summer 皮肤工厂：具体工厂
    /// </summary>
    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton() => new SummerButton();

        public ITextField CreaTextField() => new SummerTextField();

        public IComboBox CreateComboBox() => new SummerComboBox();
    }
}
