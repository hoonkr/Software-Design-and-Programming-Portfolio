using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class AudioFileHandler : IHandler
    {
       

        public IHandler Handler { get; set; }
        public void Process(File file)
        {
            if (file.Type == "audio")
            {
                Console.WriteLine("Process and saving audio file... by Audio Handler");
            }
            else
            {
                Console.WriteLine("Audio Handler forwards request to Video Handler");
                Handler.Process(file);
            }
        }
    }
}