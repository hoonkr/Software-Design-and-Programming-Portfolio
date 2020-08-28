using System;
using System.Reflection.Metadata;

namespace worksheet_eight_behavioural_design_patterns
{
    public class TextFileHandler: IHandler
    {

        public IHandler Handler { get; set; }

        public void Process(File file)
        {
            if (file.Type == "text")
            {
                Console.WriteLine("Process and saving text file... by Text Handler");
            }
            else
            { 
                Console.WriteLine("Text Handler forwards request to Doc Handler"); 
                Handler.Process(file);
            }
            
        }
    }
}