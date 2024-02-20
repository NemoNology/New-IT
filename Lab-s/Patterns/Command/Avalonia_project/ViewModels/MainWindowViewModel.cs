using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Avalonia_project.Models.Implementations;
using Avalonia_project.Models.Interfaces;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace Avalonia_project.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly Shape _shape;
    private readonly ShapeCommandsController _commandsController = new();
	private double _size = .5;
	private byte _valueR;
	private byte _valueG;
	private byte _valueB;
	
	public MainWindowViewModel(Shape shape)
	{
		_shape = shape;
	}

    public double Size
    {
        get => _size;
        set => this.RaiseAndSetIfChanged(ref _size, value);
    }
	public byte ValueR
	{
		get => _valueR;
		set => this.RaiseAndSetIfChanged(ref _valueR, value);
    }
    public byte ValueG
    {
        get => _valueG;
        set => this.RaiseAndSetIfChanged(ref _valueG, value);
    }
    public byte ValueB
    {
        get => _valueB;
        set => this.RaiseAndSetIfChanged(ref _valueB, value);
    }
    public ObservableCollection<ICommand> Commands => _commandsController.Commands;

    public void ChangeColor() =>
        _commandsController.AddCommand(
            new ChangeShapeColor(
                _shape,
                new SolidColorBrush(Color.FromRgb(_valueR, _valueG, _valueB))));

    public void ChangeSize() =>
        _commandsController.AddCommand(
            new ChangeShapeSize(_shape, _size));

    public void Undo() => _commandsController.Undo();
}
