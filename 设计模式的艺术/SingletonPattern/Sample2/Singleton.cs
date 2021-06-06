namespace SingletonPattern.Sample2
{
    public class Singleton
    {
        private Singleton() { }

        private static class HolderClass
        {
            internal static readonly Singleton Instance = new();
        }

        public static Singleton Instance => HolderClass.Instance;
    }
}