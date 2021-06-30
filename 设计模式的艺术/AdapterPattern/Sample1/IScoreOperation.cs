using System;
using System.Collections.Concurrent;

namespace AdapterPattern.Sample1
{
    /// <summary>
    /// 抽象成绩操作类：目标接口
    /// </summary>
    public interface IScoreOperation
    {
        /// <summary>
        /// 成绩排序
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        int[] Sort(int[] items);

        /// <summary>
        /// 成绩查找
        /// </summary>
        /// <param name="items"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        int Search(int[] items, int key);
    }
}