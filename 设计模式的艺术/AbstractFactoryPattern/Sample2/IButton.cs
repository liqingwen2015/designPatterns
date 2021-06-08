using System;
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
    /// Spring 按钮类：具体产品
    /// </summary>
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮。");
        }
    }

    /// <summary>
    /// Summer 按钮类：具体产品
    /// </summary>
    public class SummerButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅蓝色按钮。");
        }
    }

    /// <summary>
    /// 文本框接口：抽象产品
    /// </summary>
    public interface ITextField
    {
        void Display();
    }

    /// <summary>
    /// Spring 文本框类：具体产品
    /// </summary>
    public class SpringTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框文本框。");
        }
    }

    /// <summary>
    /// Summer 文本框类：具体产品
    /// </summary>
    public class SummerTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框文本框。");
        }
    }

    /// <summary>
    /// 组合框接口：抽象产品
    /// </summary>
    public interface IComboBox
    {
        void Display();
    }

    /// <summary>
    /// Spring 组合框类：具体产品
    /// </summary>
    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框组合框。");
        }
    }
}
