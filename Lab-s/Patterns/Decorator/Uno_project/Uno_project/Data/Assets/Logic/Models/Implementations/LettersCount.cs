using Uno_project.Logic.Models.Interfaces;

namespace Uno_project.Logic.Models.Implementations;

internal class LettersCount(ITextAnalyzer textAnalyzer) : ITextAnalyzerDecorator(textAnalyzer)
{
    public override string Analize(string text)
    {
        int result = 0;

        foreach (char c in text)
            if (char.IsLetter(c))
                result++;

        return $"Количество букв в тексте: {result};\n" + base.Analize(text);
    }
}

