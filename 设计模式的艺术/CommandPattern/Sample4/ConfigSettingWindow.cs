using System.Collections.Generic;

namespace CommandPattern.Sample4
{
    /// <summary>
    /// 配置文件设置窗口（请求发送者）
    /// </summary>
   public class ConfigSettingWindow
    {
        /// <summary>
        /// 命令集合，将每次操作记录下来
        /// </summary>
        public List<Command> Commands { get; } = new();

        public Command Command { get; set; }

        public void Call(string args)
        {
            Command.Execute(args);
            Commands.Add(Command);
        }

        public void Save() => FileUtil.WriteCommans(Commands);


        /// <summary>
        /// 恢复
        /// </summary>
        public void Recover()
        {
            foreach (var obj in FileUtil.ReadCommands())
            {
                obj.Execute();
            }
        }
    }
}