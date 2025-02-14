namespace uLab4.Interpretators;

public class QuoteFixer:ITextFixer
{
    public void Interpret(Context context)
    {
        context.Text = context.Text.Replace("“", "«").Replace("”", "»");
    }
}