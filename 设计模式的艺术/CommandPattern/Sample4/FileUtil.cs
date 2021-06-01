using System;
using System.Collections.Generic;

namespace CommandPattern.Sample4
{
    /// <summary>
    /// 工具类
    /// </summary>
    internal class FileUtil
    {
        /// <summary>
        /// 临时命令集合
        /// </summary>
        /// <remarks>
        /// 这里将书中的文件存储，替换成静态变量存储
        /// 因为 Command 为抽象类和其它原因，导致序列化后进行反序列抛异常
        /// </remarks>
        private static List<Command> _tmpCommands = new();

        /// <summary>
        /// 将命令写入日志文件
        /// </summary>
        /// <param name="commands"></param>
        public static void WriteCommans(List<Command> commands)
        {
            try
            {
                _tmpCommands = commands;
            }
            catch (Exception e)
            {
                Console.WriteLine("命令保存失败！");
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 从日志文件中提取命令集合
        /// </summary>
        /// <param name="commands"></param>
        public static List<Command> ReadCommands()
        {
            try
            {
                return _tmpCommands;
            }
            catch (Exception e)
            {
                Console.WriteLine("命令读取失败！");
                Console.WriteLine(e);
                return new List<Command>();
            }
        }

    }
}