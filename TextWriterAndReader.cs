using System.IO;

namespace jegyzetelo
{
    public class TextWriterAndReader
    {
        string fileName;
        string path;
        
        public void Save(string text)
        {
            path = $@"C:\Users\balaz\Documents\c#\jegyzetelő\jegyzetelo\{fileName}";

            using (var file = File.CreateText(path))
            { 
                file.Write(text);
            }
        }

        public void saveFileName(string name)
        {
            fileName = name + ".txt";
        }

        public void loadFile(string name)
        {
            path = $@"C:\Users\balaz\Documents\c#\jegyzetelő\jegyzetelo\{fileName}";
            using (var file = File.OpenText(path))
            {
                string text = file.ReadToEnd();
            }
        }
    }
}