using System;

namespace HW_1002
{
    class FileWorker : IDisposable
    {
        public enum Mode { Read = 1, Write };
        private bool isOpen = true;
        public string Path { get; set; }
        private bool isDisposed;
        private Mode fileMode;
        public void Dispose()
        {
            if (!isDisposed)
            {
                isOpen = false;
                Console.WriteLine("Disposed done");
                isDisposed = true;
                GC.SuppressFinalize(this);
            }

        }
        public void Read()
        {
            if (fileMode == Mode.Read )
            {
                Console.WriteLine($"Reading file with path: {Path}");
            }
            else
            {
                Console.WriteLine("Can`t to Read");
            }
        }
        public void Write()
        {
            if (fileMode == Mode.Write)
            {
                Console.WriteLine($"Writing file with path: {Path}");
            }
            else
            {
                Console.WriteLine("Can`t to write");
            }
        }
        public FileWorker(string path, Mode mode)
        {
            this.Path = path;
            this.fileMode = mode;
        }
        ~FileWorker()
        {
            Dispose();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("______________With_____________________");
            using (FileWorker fw = new FileWorker("test.txt", FileWorker.Mode.Read))
            {
                fw.Write();
                fw.Read();
                fw.Dispose();
            }
            Console.WriteLine("______________Without_____________________");
            FileWorker fw1 = new FileWorker("test123.txt", FileWorker.Mode.Write);
            fw1.Read();
            fw1.Write();
            fw1.Dispose();
        }
    }
}
