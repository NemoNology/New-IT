using Avalonia.Controls.Shapes;
using Avalonia_project.Models.Interfaces;

namespace Avalonia_project.Models.Implementations
{
    internal class ChangeShapeSize : ICommand
    {
        private readonly Shape _shape;
        private readonly double _newSize;
        private (double Width, double Height) _defaultSize;

        public ChangeShapeSize(Shape shape, double newSize)
        {
            _shape = shape;
            _newSize = newSize;
            _defaultSize = (_shape.Width, _shape.Height);
        }

        /// <summary>
        /// Change shape size by new size coefficient
        /// </summary>
        public void Execute()
        {
            (_shape.Width, _shape.Height) = (_defaultSize.Width * _newSize, _defaultSize.Height * _newSize);
        }

        /// <summary>
        /// Change shape size to previous size
        /// </summary>
        public void Undo()
        {
            (_shape.Width, _shape.Height) = (_defaultSize.Width, _defaultSize.Height);
        }

        public override string ToString()
        {
            return $"Размер увеличен на коэффициент {_newSize:f2}";
        }
    }
}
