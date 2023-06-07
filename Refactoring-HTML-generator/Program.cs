namespace Refactoring_HTML_generator;

public class Program
{
    public static void Main()
    {
        CodeFactory codeFactory = new CodeFactory();

        // Create code blocks to use later
        CodeBlock techniques = new CodeBlock().AddCode("   C#").AddCode("daTAbaser").AddCode("WebbuTVeCkling ").AddCode("clean Code   ");
        CodeBlock messagesToClass = new CodeBlock().AddCode("Glöm inte att övning ger färdighet!").AddCode("Öppna boken på sida 257.");

        // Use methods too create and add code blocks to the code factory.
        codeFactory.Add(codeFactory.CreateStart());
        codeFactory.Add(codeFactory.CreateWelcomeMessage("ITHS .NET 2022", messagesToClass));
        codeFactory.Add(codeFactory.CreateList(techniques));
        codeFactory.Add(codeFactory.CreateEnd());

        for (int i = 0; i < codeFactory.Size; i++)
        {
            Console.WriteLine(codeFactory.GetCodeBlock(i).GetCode());
        }
    }
}
