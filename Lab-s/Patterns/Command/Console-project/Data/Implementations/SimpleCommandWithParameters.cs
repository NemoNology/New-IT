namespace Console_project;

public class SimpleCommandWithParameters<T> : ICommandWithParameter<T>
{
    private readonly Action<T> _action;

    public SimpleCommandWithParameters(Action<T> action)
    {
        _action = action;
    }

    public void Execute(T parameterValue)
    {
        _action(parameterValue);
    }
}