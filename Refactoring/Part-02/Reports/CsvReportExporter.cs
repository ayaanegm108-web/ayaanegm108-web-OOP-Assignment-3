using System;
using System.Collections.Generic;
using System.Linq;
using Part_02.Reports;

namespace RefactoringLab.Part02.Reports;
public class CsvReportExporter : ReportExporter
{
     protected override string Format(List<string[]> rows) =>
        string.Join(Environment.NewLine, rows.Select(r => string.Join(",", r)));
}
