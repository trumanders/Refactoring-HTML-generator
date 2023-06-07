namespace Refactoring_HTML_generator;

public class CodeBlock : IOutputable
{

    private List<string> code;
    public List<string> Code { get { return code; } }

    public CodeBlock()
    {
        code = new List<string>();
    }

    public CodeBlock AddCode(string code)
    {
        this.Code.Add(code);
        return this;
    }

    public string GetCode()
    {
        string output = "";
        foreach (string bitOfCode in code)
        {
            output += bitOfCode + "\n";
        }
        return output;
    }
}