using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia_project.ViewModels;

namespace Avalonia_project.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(rect);
    }
}