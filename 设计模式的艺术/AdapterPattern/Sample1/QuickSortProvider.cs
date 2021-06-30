namespace AdapterPattern.Sample1
{
    /// <summary>
    /// 快速排序类：适配者
    /// </summary>
    public class QuickSortProvider
    {

        public int[] QuickSort(int[] array)
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        private void Sort(int[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Partitioner(array, p, r);
                Sort(array, p, q - 1);
                Sort(array, q + 1, r);
            }
        }

        private int Partitioner(int[] a, int p, int r)
        {
            int x = a[r];
            int j = p - 1;
            for (int i = p; i <= r - 1; i++)
            {
                if (a[i] <= x)
                {
                    j++;
                    Swap(a, j, i);
                }
            }

            Swap(a, j + 1, r);
            return j + 1;
        }

        private void Swap(int[] a, int i, int j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
    }
}