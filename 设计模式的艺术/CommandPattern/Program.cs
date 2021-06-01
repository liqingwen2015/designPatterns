using System;
using CommandPattern.Sample1;
using CommandPattern.Sample3;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // smaple1
            {
                //var fbsw = new FBSettingWindow("功能键设置");

                //var btn1 = new FunctionButton("功能键1");
                //var btn2 = new FunctionButton("功能键2");

                //var cmd1 = new HelpCommand();
                //var cmd2 = new MinimizeCommand();

                //// 将命令对象注入功能键
                //btn1.Command = cmd1;
                //btn2.Command = cmd2;

                //fbsw.AddFunctionButton(btn1);
                //fbsw.AddFunctionButton(btn2);
                //fbsw.Display();

                //// 调用功能键的业务方法
                //btn1.OnClick();
                //btn2.OnClick();
            }

            // smaple2
            {
                var form = new CaculatorForm();
                AbstractCommand command = new AddCommand();
                form.Command = command;

                form.Compute(10);
                form.Compute(5);
                form.Compute(10);
                form.Undo();
            }
        }
    }
}
