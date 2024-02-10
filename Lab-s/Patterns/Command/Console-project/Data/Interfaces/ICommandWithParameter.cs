namespace Console_project;

public interface ICommandWithParameter<T>
{
    void Execute(T parameter);
}
