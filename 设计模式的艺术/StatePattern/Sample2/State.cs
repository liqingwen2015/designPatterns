namespace StatePattern.Sample2
{
    public abstract class State
    {
        public abstract void On(Switch s);
        public abstract void Off(Switch s);
    }
}