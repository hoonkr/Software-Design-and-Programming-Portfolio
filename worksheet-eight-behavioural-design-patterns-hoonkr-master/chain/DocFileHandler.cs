using System;
using System.Security.Cryptography;

namespace worksheet_eight_behavioural_design_patterns
{
    public class DocFileHandler : IHandler
    {

        public IHandler Handler { get; set; }
        public void Process(File file)
        {
            if (file.Type == "doc")
            {
                Console.WriteLine("Process and saving doc file ... by Doc Handler");
            }
            else
            {
                Console.WriteLine("Doc Handler forwards request to Excel Handler");
                Handler.Process(file);
            }
        }
    }
}