namespace OOTPLab41;

public class ExcelReportGenerator : IReportGenerator
{
    private ReportTemplate template;

    public ExcelReportGenerator(ReportTemplate template)
    {
        this.template = template;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating Excel report...");
        // Generate report using the provided template
        this.template.GenerateReport();
    }
}