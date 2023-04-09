using OOTPLab41;

public class ReportClient
{
    public static void Main()
    {
        // Create some report data
        List<string> salesData = new List<string> { "Product A: $1000", "Product B: $2000", "Product C: $3000" };
        List<string> inventoryData = new List<string> { "Product A: 10 units", "Product B: 20 units", "Product C: 30 units" };

        // Create some report templates
        ReportTemplate salesTemplate = new SalesReportTemplate(salesData, "quarterly");
        ReportTemplate inventoryTemplate = new InventoryReportTemplate(inventoryData, "bar chart");

        // Create some report generators
        IReportGenerator excelSalesGenerator = new ExcelReportGenerator(salesTemplate);
        IReportGenerator pdfInventoryGenerator = new PDFReportGenerator(inventoryTemplate);

        // Generate some reports
        excelSalesGenerator.GenerateReport();
        pdfInventoryGenerator.GenerateReport();
    }


}