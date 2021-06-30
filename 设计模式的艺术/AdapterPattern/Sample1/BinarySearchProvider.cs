namespace AdapterPattern.Sample1
{
    /// <summary>
    /// 快速排序类：适配者
    /// </summary>
    /// <returns></returns>
    public class BinarySearchProvider
    {
        public int BinarySearch(int[] array, int key)
        {
            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int midVal = array[mid];

                if (midVal < key)
                {
                    low = mid + 1;
                }
                else if (midVal > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return 1;
                }
            }

            return -1;
        }
    }
}