namespace Console_project;

public class SimpleCommand : ICommand
{
    private readonly Action _action;

    public SimpleCommand(Action action)
    {
        _action = action;
    }

    public void Execute()
    {
        _action();
    }
}

