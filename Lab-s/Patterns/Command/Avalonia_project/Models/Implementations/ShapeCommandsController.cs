using Avalonia_project.Models.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Avalonia_project.Models.Implementations
{
    internal class ShapeCommandsController
    {
        private readonly ObservableCollection<ICommand> _commands = new();
        public ObservableCollection<ICommand> Commands => _commands;

        public void AddCommand(ICommand command)
        {
            command.Execute();
            _commands.Add(command);
        }

        public void Undo()
        {
            if (_commands.Count > 0 )
            {
                _commands[^1].Undo();
                _commands.RemoveAt(_commands.Count - 1);
            }
        }
    }
}
