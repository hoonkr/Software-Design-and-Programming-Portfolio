using System;

namespace ProtectedProxy
{
    public class Owner : IStaff
    {
        public bool IsOwner()
        {
            return true;
        }

        public string GenerateDailyReport()
        {
            return null;
        }

        public IReportGeneratorProxy ReportGenerator { get; set; }
    }
}