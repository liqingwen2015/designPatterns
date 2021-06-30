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
            var json = File.ReadAllText($"Configs/{PatternConfigJsonPath}.json").ToJson<dynamic>();
            return (T)Activator.CreateInstance(Assembly.Load(AssemblyName).GetTypes().First(x => x.FullName == (string)json.className));
        }

        protected (T1, T2) CreateInstance<T1, T2>()
        {
            var json = File.ReadAllText($"Configs/{PatternConfigJsonPath}.json").ToJson<dynamic>();
            var types = Assembly.Load(AssemblyName).GetTypes();
            var v1 = json!.className[0];
            var v2 = json.className[1];

            return ((T1)Activator.CreateInstance(types.First(x => x.FullName == (string)v1)),
                (T2)Activator.CreateInstance(types.First(x => x.FullName == (string)v2)));

        }

        protected virtual string PatternConfigJsonPath { get; }
        protected virtual string AssemblyName { get; }
    }
}