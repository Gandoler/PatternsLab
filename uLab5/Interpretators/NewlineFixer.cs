namespace uLab4.Interpretators;

public class NewlineFixer : ITextFixer
{
    public void Interpret(Context context)
    {
        context.Text = System.Text.RegularExpressions.Regex.Replace(context.Text, @"(\r?\n){2,}", "\n");        
    }
}