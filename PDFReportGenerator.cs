public class PDFReportGenerator : IReportGenerator
{
    private ReportTemplate template;

    public PDFReportGenerator(ReportTemplate template)
    {
        this.template = template;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating PDF report...");
        // Generate report using the provided template
        this.template.GenerateReport();
    }
}