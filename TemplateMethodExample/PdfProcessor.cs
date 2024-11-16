namespace TemplateMethodExample;

public class PdfProcessor : DocumentProcessor
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening PDF file...");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing data from PDF file...");
    }
}