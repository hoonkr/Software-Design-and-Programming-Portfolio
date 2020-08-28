using System;
using System.Collections.Generic;

namespace worksheet_eight_behavioural_design_patterns
{
    public static class TestChainOfResponsibility
    {
        public static void Main(string[] args)
        {
            IHandler textHandler = new TextFileHandler();
            IHandler docHandler = new DocFileHandler();
            IHandler excelHandler = new ExcelFileHandler();
            IHandler audioHandler = new AudioFileHandler();
            IHandler videoHandler = new VideoFileHandler();
            IHandler imageHandler = new ImageFileHandler();

            textHandler.Handler = docHandler;
            docHandler.Handler = excelHandler;
            excelHandler.Handler = audioHandler;
            audioHandler.Handler = videoHandler;
            videoHandler.Handler = imageHandler;

            var file = new File("Abc.mp3", "audio", "C:");
            textHandler.Process(file);

            Console.WriteLine("--------------------");

            file = new File("Abc.jpg", "video", "C:");
            textHandler.Process(file);

            Console.WriteLine("--------------------");

            file = new File("Abc.doc", "doc", "C:");
            textHandler.Process(file);

            Console.WriteLine("--------------------");

            file = new File("Abc.bat", "bat", "C:");
            textHandler.Process(file);
        }
    }
}