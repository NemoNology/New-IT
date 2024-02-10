using Uno_project.Logic.Models.Implementations;
namespace Uno_project.Logic.ViewModels;

internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string _text = "";
    [ObservableProperty]
    private string _result = "";

    [RelayCommand]
    public void Analize()
    {
        Result =
            new WordsCount(
                new LettersCount(
                    new VowelLettersCount(
                        new TextAnalyzer()
                    )
                )
            ).Analize(Text);
    }

}