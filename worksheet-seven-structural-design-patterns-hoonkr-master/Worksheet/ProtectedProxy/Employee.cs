using System;

namespace ProtectedProxy
{
    public class Employee : IStaff
    {
        public bool IsOwner()
        {
            return false;
        }

        public string GenerateDailyReport()
        {
            return null;
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}