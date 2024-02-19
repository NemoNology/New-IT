using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia_project.Models.Interfaces;

namespace Avalonia_project.Models.Implementations
{
    internal class ChangeShapeColor : ICommand
    {
        private readonly Shape _shape;
        private readonly IBrush _newBrush;
        private IBrush? _previousBrush;

        public ChangeShapeColor(Shape shape, IBrush newBrush)
        {
            _shape = shape;
            _newBrush = newBrush;
            _previousBrush = _shape.Fill;
        }

        /// <summary>
        /// Change shape color to new IBrush color
        /// </summary>
        public void Execute()
        {
            _shape.Fill = _newBrush;
        }

        /// <summary>
        /// Change shape color to previous color
        /// </summary>
        public void Undo()
        {
            _shape.Fill = _previousBrush;
        }

        public override string ToString()
        {
            return $"Цвет: {_previousBrush} -> {_newBrush}";
        }
    }
}
