using uLab4.Interpretators;

namespace uLab4;

class MainInterpretator
{
    private readonly List<ITextFixer> _fixers = new();

    public MainInterpretator AddFixer(ITextFixer fixer)
    {
        _fixers.Add(fixer);
        return this;
    }

    public void Interpret(Context context)
    {
        foreach (var fixer in _fixers)
        {
            fixer.Interpret(context);
        }
    }
}