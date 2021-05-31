namespace StatePattern
{
    public abstract class State
    {
        public abstract void Handle();
    }

    public class ConcreteState : State
    {
        public void Handle()
        {

        }
    }
}