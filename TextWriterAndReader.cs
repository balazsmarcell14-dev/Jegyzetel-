using System.IO;

namespace jegyzetelo
{
    public class TextWriterAndReader
    {
        private string _filePath = string.Empty;
        //private const string cPath = @"C:\Users\balaz\Downloads\Jegyzetel--main\Jegyzetel--main\";

        public void Save(string text)
        {
            using (var file = CreateFile())
            {
                file.Write(text);
            }
        }

        public StreamWriter CreateFile()
        {
            return File.CreateText(FilePath);
        }

        public string FilePath
        {
            get { return _filePath; }
            set
            {
                if (!value.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    _filePath = value + ".txt";
                }
                else
                {
                    _filePath = value;
                }
            }
        }

        public string ReadFile()
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("Ilyen fájl nem létezik.");
            }
            
            using (var file = File.OpenText(FilePath))
            {
                return file.ReadToEnd();
            }
        }
    }
}