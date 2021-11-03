using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesReport salesReport = new SalesReport();
            salesReport.Format = new PdfFormat();
            salesReport.Format = new ExcelFormat();
        }
    }

    public class Report
    {
        public ReportFormat Format { get; set; }
    }
    public class HRReport : Report
    {

    }
    public class SalesReport: Report
    {

    }
   
    public class ReportFormat
    {

    }
    public class ExcelFormat:ReportFormat
    {

    }
    public class PdfFormat:ReportFormat
    {

    }
   
}
