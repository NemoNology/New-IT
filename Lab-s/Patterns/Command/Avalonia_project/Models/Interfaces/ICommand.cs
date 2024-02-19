namespace Avalonia_project.Models.Interfaces
{
    public interface ICommand
    {
        /// <summary>
        /// Execute command
        /// </summary>
        void Execute();
        /// <summary>
        /// Undo command to previous state
        /// </summary>
        void Undo();
    }
}
