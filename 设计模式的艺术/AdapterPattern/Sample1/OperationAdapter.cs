namespace AdapterPattern.Sample1
{
    /// <summary>
    /// 操作适配器：适配器
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        /// <summary>
        /// 定义适配者 QuickSort 对象
        /// </summary>
        private readonly QuickSortProvider _quickSortProvider;

        /// <summary>
        /// 定义适配者 BinarySearch 对象
        /// </summary>

        private readonly BinarySearchProvider _binarySearchProvider;

        public OperationAdapter()
        {
            _quickSortProvider = new QuickSortProvider();
            _binarySearchProvider = new BinarySearchProvider();
        }

        /// <summary>
        /// 调用适配者类 QuickSort 的排序方法
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int[] Sort(int[] items) => _quickSortProvider.QuickSort(items);

        /// <summary>
        /// 调用适配者类 BinarySearch 的查找方法
        /// </summary>
        /// <param name="items"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public int Search(int[] items, int key)
        {
            return _binarySearchProvider.BinarySearch(items, key);
        }
    }
}