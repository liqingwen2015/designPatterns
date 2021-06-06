using System;
using System.Collections.Generic;

namespace CommandPattern.Sample1
{
    /// <summary>
    /// 功能键设置窗口类
    /// </summary>
    public class FBSettingWindow
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 功能键
        /// </summary>
        public List<FunctionButton> FunctionButtons { get; set; } = new();

        public FBSettingWindow(string title)
        {
            Title = title;
        }

        public void AddFunctionButton(FunctionButton button)
        {
            FunctionButtons.Add(button);
        }

        public void RemoveFunctionButton(FunctionButton button)
        {
            FunctionButtons.Remove(button);
        }

        /// <summary>
        /// 显示
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"显示窗口：{Title}");
            Console.WriteLine("显示功能键：");

            foreach (var button in FunctionButtons)
            {
                Console.WriteLine(button.Name);
            }
        }
    }
}