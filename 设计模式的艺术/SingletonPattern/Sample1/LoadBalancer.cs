using System;
using System.Collections.Generic;

namespace SingletonPattern.Sample1
{
    public class LoadBalancer
    {
        /// <summary>
        /// 私有静态成员变量，存储唯一实例
        /// </summary>
        private static LoadBalancer _instance;

        /// <summary>
        /// 服务器集合
        /// </summary>
        private readonly List<string> _servers = new();

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private LoadBalancer()
        {

        }

        /// <summary>
        /// 公有静态成员，返回唯一实例
        /// </summary>
        public static LoadBalancer Instance => _instance ??= new LoadBalancer();

        /// <summary>
        /// 增加服务器
        /// </summary>
        /// <param name="server"></param>
        public void AddServer(string server) => _servers.Add(server);

        /// <summary>
        /// 删除服务器
        /// </summary>
        /// <param name="server"></param>
        public void RemoveServer(string server) => _servers.Remove(server);

        /// <summary>
        /// 获取服务器
        /// </summary>
        /// <returns></returns>
        public string GetServer() => _servers[new Random().Next(_servers.Count)];
    }
}