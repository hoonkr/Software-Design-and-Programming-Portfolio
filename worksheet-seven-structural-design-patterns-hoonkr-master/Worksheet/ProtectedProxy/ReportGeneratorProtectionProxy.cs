namespace ProtectedProxy
{
    public class ReportGeneratorProtectionProxy : IReportGeneratorProxy
    {
        private IReportGenerator reportGenerator;
        private IStaff _staff;

        public ReportGeneratorProtectionProxy(IStaff staff)
        {
            _staff = staff;
        }

        public string GenerateDailyReport()
        {
            return null;
        }
    }
}