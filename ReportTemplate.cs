public abstract class ReportTemplate
{
    protected List<string> data;

    public ReportTemplate(List<string> data)
    {
        this.data = data;
    }

    // Abstract method that will be implemented by subclasses
    public abstract void GenerateReport();

    // Common method used by all subclasses
    public void FormatData()
    {
        Console.WriteLine("Formatting report data...");
        // Add any common formatting logic here
    }
}