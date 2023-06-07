
namespace Refactoring_HTML_generator;

public static class StringExtensions
{
    public static string FixCasingAndTrim(this string text)
    {
        string modifiedText = text.Trim();
        return "<p>" + modifiedText[0].ToString().ToUpper() + modifiedText.Substring(1).ToLower() + "</p>";
    }
}