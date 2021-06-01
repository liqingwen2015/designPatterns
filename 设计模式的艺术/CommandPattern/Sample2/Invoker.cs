namespace CommandPattern.Sample2
{
    class Invoker
    {
        public CommandQueue CommandQueue { get; set; }

        public Invoker(CommandQueue commandQueue)
        {
            CommandQueue = commandQueue;
        }

        public void Call()
        {
            CommandQueue.Execute();
        }
    }
}