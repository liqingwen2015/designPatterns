using System;

namespace CommandPattern.Sample4
{
    /// <summary>
    /// 配置文件操作（请求接收者）
    /// </summary>
    [Serializable]
    public class ConfigOperator
    {
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="args"></param>
        public void Insert(string args) => Console.WriteLine($"增加新节点：{args}");

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="args"></param>
        public void Modify(string args) => Console.WriteLine($"修改节点：{args}");

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="args"></param>
        public void Delete(string args) => Console.WriteLine($"删除节点：{args}");
    }
}