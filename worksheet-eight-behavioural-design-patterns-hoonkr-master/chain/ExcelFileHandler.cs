using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class ExcelFileHandler : IHandler
    {
       

        public IHandler Handler { get; set; }
        public void Process(File file)
        {
            if (file.Type == "excel")
            {
                Console.WriteLine("Process and saving excel file... by Excel Handler" );
            }
            else
            {
                Console.WriteLine("Excel Handler forwards request to Audio Handler");
                Handler.Process(file);
            }
        }
    }
}