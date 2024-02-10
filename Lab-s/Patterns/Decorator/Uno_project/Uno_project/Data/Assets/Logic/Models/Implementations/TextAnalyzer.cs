using Uno_project.Logic.Models.Interfaces;

namespace Uno_project.Logic.Models.Implementations;

internal class TextAnalyzer : ITextAnalyzer
{
    public override string Analize(string text)
    {
        return $"Длина текста: {text.Length};";
    }
}
