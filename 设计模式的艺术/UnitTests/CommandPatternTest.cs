using System;
using CommandPattern.Sample1;
using CommandPattern.Sample3;
using CommandPattern.Sample4;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CommandPatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            var fbsw = new FBSettingWindow("功能键设置");

            var btn1 = new FunctionButton("功能键1");
            var btn2 = new FunctionButton("功能键2");

            var cmd1 = new HelpCommand();
            var cmd2 = new MinimizeCommand();

            // 将命令对象注入功能键
            btn1.Command = cmd1;
            btn2.Command = cmd2;

            fbsw.AddFunctionButton(btn1);
            fbsw.AddFunctionButton(btn2);
            fbsw.Display();

            // 调用功能键的业务方法
            btn1.OnClick();
            btn2.OnClick();
        }


        [TestMethod]
        public void Sample2()
        {
            var form = new CaculatorForm();
            AbstractCommand command = new AddCommand();
            form.Command = command;

            form.Compute(10);
            form.Compute(5);
            form.Compute(10);
            form.Undo();
        }

        [TestMethod]
        public void Sample3()
        {
            var csw = new ConfigSettingWindow();
            CommandPattern.Sample4.Command command;
            ConfigOperator co = new ConfigOperator();

            // 4 次对配置文件的更改
            command = new InsertCommand("增加");
            command.ConfigOperator = co;
            csw.Command = command;
            csw.Call("网站首页");

            command = new InsertCommand("增加");
            command.ConfigOperator = co;
            csw.Command = command;
            csw.Call("端口号");

            command = new ModifyCommand("修改");
            command.ConfigOperator = co;
            csw.Command = command;
            csw.Call("网站首页");

            command = new ModifyCommand("修改");
            command.ConfigOperator = co;
            csw.Command = command;
            csw.Call("端口号");

            Console.WriteLine("------------------------------");
            Console.WriteLine("保存配置");
            csw.Save();

            Console.WriteLine("------------------------------");
            Console.WriteLine("恢复配置");
            Console.WriteLine("------------------------------");
            csw.Recover();
        }
    }
}
