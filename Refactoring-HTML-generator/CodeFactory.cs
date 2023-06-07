namespace Refactoring_HTML_generator;

public class CodeFactory : IEditable
{
    private int size = 0;
    public int Size { get { return size; } }
    private List<CodeBlock> codeBlocks;
    public CodeFactory()
    {
        codeBlocks = new List<CodeBlock>();
    }

    public CodeBlock CreateStart()
    {
        CodeBlock startCode = new CodeBlock().AddCode("<!DOCTYPE html>").AddCode("<html>").AddCode("<body>").AddCode("<main>");
        return startCode;
    }


    public CodeBlock CreateWelcomeMessage(string className, CodeBlock messages)
    {
        CodeBlock welcomeCode = new CodeBlock().AddCode($"<h1> Välkomna {className}! </h1>");
        foreach (string message in messages.Code)
        {
            welcomeCode.AddCode($"<p><b> Meddelande: </b> {message} </p>");
        }
        return welcomeCode;
    }


    public CodeBlock CreateList(CodeBlock listItems)
    {
        CodeBlock newList = new CodeBlock();
        foreach (string listItem in listItems.Code)
        {
            newList.AddCode(listItem.FixCasingAndTrim());
        }
        return newList;
    }

    public CodeBlock CreateEnd()
    {
        return new CodeBlock().AddCode("</main>").AddCode("</body>").AddCode("</html>");
    }

    public void Add(CodeBlock codeBlock)
    {
        codeBlocks.Add(codeBlock);
        size++;
    }

    public void Delete(int index)
    {
        codeBlocks.RemoveAt(index);
    }

    public CodeBlock GetCodeBlock(int index)
    {
        return codeBlocks[index];
    }


}
