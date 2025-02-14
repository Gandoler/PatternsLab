namespace uLab4.Interpretators;

public class DashFixer: ITextFixer
{
    public void Interpret(Context context)
    {
        context.Text = context.Text.Replace(" - ", " — ");
    }
}