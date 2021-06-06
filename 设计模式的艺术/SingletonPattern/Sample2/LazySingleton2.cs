namespace SingletonPattern.Sample2
{
    public class LazySingleton2
    {
        private static LazySingleton2 _instance = null;

        private static readonly object Locker = new();

        private LazySingleton2() { }

        public static LazySingleton2 Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                lock (Locker)
                {
                    return _instance ??= new LazySingleton2();
                }

            }
        }
    }
}