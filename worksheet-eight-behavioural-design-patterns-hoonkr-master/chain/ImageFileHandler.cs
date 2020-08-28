using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class ImageFileHandler : IHandler
    {
        
        public IHandler Handler { get; set; }
        public void Process(File file)
        {
            if (file.Type == "image")
            {
                Console.WriteLine("Process and saving image file... by Image Handler");
            }
            else
            {
                Console.WriteLine("File not supported");
            }
        }
    }
}