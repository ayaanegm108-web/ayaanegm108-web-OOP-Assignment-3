using Part_02.Enrollment;
using RefactoringLab.Part02.Enrollment;
using RefactoringLab.Part02.Reports;

Console.WriteLine("=== Reports ===");
var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
Directory.CreateDirectory(outDir);

new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
Console.WriteLine($"Wrote reports to {outDir}");
Console.WriteLine();

Console.WriteLine("=== EnrollmentFacade ===");
var studentId = "S100";
var courseId = "CS201";
var amount = 1500m;

EnrollmentFacade facade = new EnrollmentFacade();
//var payment = new PaymentGateway();
//var seats = new SeatInventory();
//var invoices = new InvoiceGenerator();
//var email = new EmailService();

facade.Enroll(studentId, courseId, amount);
