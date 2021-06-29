using System;
using System.IO;
using System.Linq;
using System.Reflection;
using NiuX.Extensions;

namespace UnitTests
{
    public class TestBase
    {
        protected T CreateInstance<T>()
        {
            var json = File.ReadAllText("Configs/"+PatternConfigJsonPath).ToJson<dynamic>();
            return (T)Activator.CreateInstance(Assembly.Load(AssemblyName).GetTypes().First(x => x.FullName == (string)json.className));
        }

        protected virtual string PatternConfigJsonPath { get; }
        protected virtual string AssemblyName { get; }
    }
}