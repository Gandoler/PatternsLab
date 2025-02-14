using uLab4;
using uLab4.Interpretators;

class Program
{
    static void Main()
    {
        string inputText = @"
Это  пример  текста  с множеством ошибок:
1. Пробелы  между словами  должны быть единичными, но здесь  два.
2. Использование дефиса - это не тире. Тире выглядит как '—'.
3. Вместо кавычек “” должны использоваться «» — стандартные  кавычки.
4. Этот  текст  содержит  табуляции,    которых быть не должно.
5. Пробелы в  странных  местах:  перед (скобкой),   после    запятой, перед точкой .
6. Множество пустых строк между абзацами:

    


    Первый абзац.
    
    Второй абзац.
    
    Третий абзац.
    
";
        Context context = new Context(inputText);

        Console.WriteLine("До исправления:");
        Console.WriteLine(context.Text);

        var interpreter = new MainInterpretator()
            .AddFixer(new SpaceFixer())
            .AddFixer(new DashFixer())
            .AddFixer(new QuoteFixer())
            .AddFixer(new PunctuationFixer())
            .AddFixer(new NewlineFixer());

        interpreter.Interpret(context);

        Console.WriteLine("\nПосле исправления:");
        Console.WriteLine(context.Text);
    }
}