namespace Refactoring_HTML_generator;

public interface IEditable
{
    public void Add(CodeBlock codeblock);
    public void Delete(int index);
}
