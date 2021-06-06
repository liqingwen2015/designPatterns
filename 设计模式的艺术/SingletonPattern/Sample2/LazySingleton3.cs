namespace SingletonPattern.Sample2
{
    public class LazySingleton3
    {
        private static volatile LazySingleton3 _instance = null;

        private static readonly object Locker = new();

        private LazySingleton3() { }

        public static LazySingleton3 Instance
        {
            get
            {
                // 第一重判断
                if (_instance == null)
                {
                    // 锁定代码块
                    lock (Locker)
                    {
                        // 第二重判断
                        if (_instance == null)
                        {
                            // 创建单例实例
                            _instance = new LazySingleton3();
                        }
                    }
                }

                return _instance;

            }
        }
    }
}