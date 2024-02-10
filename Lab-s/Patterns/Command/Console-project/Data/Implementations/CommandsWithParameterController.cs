namespace Console_project;

public class CommandsWithParameterController<T>
{
    public Dictionary<string, ICommandWithParameter<T>> CommandsDictionary { get; set; }

    public CommandsWithParameterController()
    {
        CommandsDictionary = new();
    }

    public void Execute(string commandID, T parameterValue)
    {
        if (CommandsDictionary.TryGetValue(commandID, out var command))
            command.Execute(parameterValue);
    }
}
