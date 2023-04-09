public class SalesReportTemplate : ReportTemplate
{
    private string filter;

    public SalesReportTemplate(List<string> data, string filter) : base(data)
    {
        this.filter = filter;
    }

    public override void GenerateReport()
    {
        Console.WriteLine($"Filtering sales report data using {this.filter}...");
        // Filter data using the provided filter
        // Generate report using the filtered data
        this.FormatData();
        Console.WriteLine("Generating sales report...");
        foreach (var item in this.data)
        {
            Console.WriteLine(item);
        }
    }
}