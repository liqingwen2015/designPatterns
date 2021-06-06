using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonPattern.Sample1;
using SingletonPattern.Sample2;

namespace UnitTests
{
    [TestClass]
    public class SingletonPatternTest
    {
        [TestMethod]
        public void Sample1()
        {
            // 创建 4 个 LoadBalancer 对象
            var b1 = LoadBalancer.Instance;
            var b2 = LoadBalancer.Instance;
            var b3 = LoadBalancer.Instance;
            var b4 = LoadBalancer.Instance;

            // 判断服务器负载均衡器是否相同
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("服务器负载均衡器具有唯一性！");
            }

            // 增加服务器
            b1.AddServer("Server 1");
            b1.AddServer("Server 2");
            b1.AddServer("Server 3");
            b1.AddServer("Server 4");

            // 模拟客户端请求的分发
            for (int i = 0; i < 10; i++)
            {
                var server = b1.GetServer();
                Console.WriteLine($"分发请求至服务器：{server}");
            }
        }

        [TestMethod]
        public void Sample2()
        {
            var s1 = Singleton.Instance;
            var s2 = Singleton.Instance;

            Console.WriteLine(s1 == s2);
        }
    }
}