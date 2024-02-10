using System.Runtime.InteropServices;

namespace Console_project;

public class CommandsController
{
    public Dictionary<string, ICommand> CommandsDictionary { get; set; }

    public CommandsController()
    {
        CommandsDictionary = new();
    }

    public void Execute(string commandID)
    {
        if (CommandsDictionary.TryGetValue(commandID, out var command))
            command.Execute();
    }
}
