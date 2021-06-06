namespace SingletonPattern.Sample2
{
    public class LazySingleton
    {
        private static LazySingleton _instance = null;

        private static readonly object Locker = new();

        private LazySingleton() { }

        public static LazySingleton Instance
        {
            get
            {
                lock (Locker)
                {
                    return _instance ??= new LazySingleton();
                }

            }
        }
    }
}