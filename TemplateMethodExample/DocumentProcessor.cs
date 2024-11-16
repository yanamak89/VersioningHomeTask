namespace TemplateMethodExample;

public abstract class DocumentProcessor
{
    public void ProcessDocument()
    {
        OpenFile();
        ParseData();
        SaveReport();
    }

    protected abstract void OpenFile();
    protected abstract void ParseData();

    private void SaveReport()
    {
        Console.WriteLine("Report has been saved.");
    }

}