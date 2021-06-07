using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace CommandPattern.Sample4
{
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class Command
    {
        public string Name { get; set; }

        public string Args { get; set; }

        public ConfigOperator ConfigOperator { get; set; }

        protected Command(string name) => Name = name;

        public abstract void Execute(string args);

        public abstract void Execute();

    }
}