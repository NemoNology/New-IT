using Uno_project.Logic.Models.Interfaces;

namespace Uno_project.Logic.Models.Implementations;

internal class VowelLettersCount(ITextAnalyzer textAnalizer) : ITextAnalyzerDecorator(textAnalizer)
{
    public override string Analize(string text)
    {
        int result = 0;

        foreach (char c in text)
            if (char.IsLetter(c)
                && "уеыаоэяию".Contains(c.ToString(), StringComparison.InvariantCultureIgnoreCase)
                    )
                result++;

        return $"Количество гласных букв в тексте: {result};\n" + base.Analize(text);
    }
}