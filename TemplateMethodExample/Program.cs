using TemplateMethodExample;

class Program
{
    public static void Main(string[] args)
    {
        DocumentProcessor docProcessor = new DocProcessor();
        docProcessor.ProcessDocument();

        Console.WriteLine();

        DocumentProcessor csvProcessor = new CsvProcessor();
        csvProcessor.ProcessDocument();

        Console.WriteLine();

        DocumentProcessor pdfProcessor = new PdfProcessor();
        pdfProcessor.ProcessDocument();
        
    }
}