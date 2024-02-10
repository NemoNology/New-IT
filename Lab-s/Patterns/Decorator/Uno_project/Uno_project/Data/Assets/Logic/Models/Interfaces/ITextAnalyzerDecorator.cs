namespace Uno_project.Logic.Models.Interfaces;

internal abstract class ITextAnalyzerDecorator(ITextAnalyzer textAnalizer) : ITextAnalyzer
{
    protected ITextAnalyzer _textAnalyzer = textAnalizer;

    public override string Analize(string text)
    {
        return _textAnalyzer.Analize(text);
    }
}

