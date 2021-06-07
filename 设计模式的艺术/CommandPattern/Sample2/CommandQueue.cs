using System.Collections.Generic;
using CommandPattern.Sample1;

namespace CommandPattern.Sample2
{
    class CommandQueue
    {
        public List<Command> Commands { get; set; } = new();

        public void AddCommand(Command command) => Commands.Add(command);

        public void RemoveCommand(Command command) => Commands.Remove(command);

        public void Execute()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}