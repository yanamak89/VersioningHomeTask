namespace TemplateMethodExample;

public class CsvProcessor : DocumentProcessor
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opeing CSV file...");
    }

    protected override void ParseData()
    {
        Console.WriteLine("Parsing data from CSV file...");
    }
}