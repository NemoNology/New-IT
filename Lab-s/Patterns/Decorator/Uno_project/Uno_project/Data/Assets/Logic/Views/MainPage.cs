using Uno_project.Logic.ViewModels;
namespace Uno_project.Logic.Views;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext(new MainViewModel(), (page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .Content(
                new Grid()
                    .Children(
                        new ScrollViewer()
                        .Content(
                            new Grid()
                            .RowDefinitions("*, auto, *")
                            .Children(
                                GetIOTextBox("Введите текст для анализа сюда")
                                .Text(
                                    x => x.Bind(() => vm.Text)
                                    .UpdateSourceTrigger(UpdateSourceTrigger.PropertyChanged)
                                    .TwoWay()),
                                new Button()
                                .Grid(row: 1)
                                .Command(() => vm.AnalizeCommand)
                                .Content("Провести анализ")
                                .HorizontalAlignment(HorizontalAlignment.Center)
                                .Margin(10),
                                GetIOTextBox("Результаты анализа будут здесь", true)
                                .Grid(row: 2)
                                .Text(
                                    x => x.Bind(() => vm.Result)
                                    .TwoWay())
                            )
                            )
                    )));
    }

    public static TextBox GetIOTextBox(string placeholderText, bool isReadOnly = false)
    {
        return
            new TextBox()
            .Margin(10)
            .AcceptsReturn(true)
            .TextWrapping(TextWrapping.Wrap)
            .PlaceholderText(placeholderText)
            .IsReadOnly(isReadOnly);
    }
}
