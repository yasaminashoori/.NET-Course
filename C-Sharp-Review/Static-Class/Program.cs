using System;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public static class FileLogger
    {
        private static readonly object lockObject = new object();
        public static string FilePath
        {
            get; set;
        }
        public static void Log(string message)
        {
            lock (lockObject)
            {
                if(!string.IsNullOrEmpty(FilePath))
                using (StreamWriter streamWriter = new StreamWriter(FilePath, true))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }
    }
}
