using Uno_project.Logic.Models.Interfaces;

namespace Uno_project.Logic.Models.Implementations;

internal class WordsCount(ITextAnalyzer textAnalizer) : ITextAnalyzerDecorator(textAnalizer)
{
    public override string Analize(string text)
    {
        bool isLetter = false;
        int result = 0;

        foreach (char c in text)
        {
            if (!isLetter && (char.IsLetter(c) || char.IsNumber(c)))
            {
                isLetter = true;
                result++;
            }
            else if (isLetter && char.IsWhiteSpace(c))
                isLetter = false;
        }

        return $"Количество слов в тексте: {result};\n" + base.Analize(text);
    }
}

