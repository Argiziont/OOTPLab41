public class InventoryReportTemplate : ReportTemplate
{
    private string visualizationMethod;

    public InventoryReportTemplate(List<string> data, string visualizationMethod) : base(data)
    {
        this.visualizationMethod = visualizationMethod;
    }

    public override void GenerateReport()
    {
        Console.WriteLine($"Visualizing inventory report data using {this.visualizationMethod}...");
        // Visualize data using the provided method
        // Generate report using the visualized data
        this.FormatData();
        Console.WriteLine("Generating inventory report...");
        foreach (var item in this.data)
        {
            Console.WriteLine(item);
        }
    }
}