using System;
using System.IO;
using System.Threading;

namespace command
{
    public class FileIOJob : IJob
    {
        private FileIO _fileIo;
        public void Run()
        {
            Console.WriteLine("Job ID: "+ Thread.CurrentThread.ManagedThreadId +" executing fileIO jobs.");
            if (_fileIo != null)
            {
                _fileIo.Execute();
            }

            try
            {
                Thread.Sleep(1000);
            }
            catch(ThreadInterruptedException)
            {
                Thread.CurrentThread.Interrupt();
            }
        }

        public void FileIO(FileIO fileIo)
        {
            _fileIo = fileIo;
        }
    }
}