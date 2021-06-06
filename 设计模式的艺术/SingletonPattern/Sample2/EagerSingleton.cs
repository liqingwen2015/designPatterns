namespace SingletonPattern.Sample2
{
    public class EagerSingleton
    {
        private EagerSingleton() { }

        public static EagerSingleton Instance { get; } = new();
    }
}