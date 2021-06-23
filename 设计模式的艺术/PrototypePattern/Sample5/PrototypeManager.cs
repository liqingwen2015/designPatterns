using System.Collections;

namespace PrototypePattern.Sample5
{
    /// <summary>
    /// 原型管理器（使用饿汉式单例实现）
    /// </summary>
    public class PrototypeManager
    {
        // 定义一个 Hashtable，用于存储原型对象
        private readonly Hashtable _ht = new();
        private static readonly PrototypeManager Pm = new();

        /// <summary>
        /// 为 Hashtable 增加公文对象
        /// </summary>
        private PrototypeManager()
        {
            _ht.Add("far", new Far());
            _ht.Add("srs", new Srs());
        }

        /// <summary>
        /// 增加新的公文对象
        /// </summary>
        /// <param name="key"></param>
        /// <param name="doc"></param>
        public void AddOfficialDocument(string key, IOfficialDocument doc) => _ht.Add(key, doc);

        /// <summary>
        /// 通过浅克隆获取新的公文对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public IOfficialDocument GetOfficialDocument(string key) => (IOfficialDocument)((IOfficialDocument)_ht[key])?.Clone();

        public static PrototypeManager GetPrototypeManager() => Pm;
    }
}