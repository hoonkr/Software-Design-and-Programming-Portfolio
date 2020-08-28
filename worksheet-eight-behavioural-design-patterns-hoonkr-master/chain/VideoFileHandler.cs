using System;

namespace worksheet_eight_behavioural_design_patterns
{
    public class VideoFileHandler: IHandler
    {
        

        public IHandler Handler { get; set; }
        public void Process(File file)
        {
            if (file.Type == "video")
            {
                Console.WriteLine("Process and saving video file... by Video Handler");
            }
            else
            {
               Console.WriteLine("Video Handler forwards request to Image Handler");
                Handler.Process(file);
            }
        }
    }
}