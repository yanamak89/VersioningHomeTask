namespace TemplateMethodExample;

public class DocProcessor : DocumentProcessor
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening DOC file...");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing data from DOC file...");
    }
}