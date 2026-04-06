using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jegyzetelo
{
    internal class DocumentList
    {
        private List<string> _documents = new List<string>();

        public IEnumerable<string> Documents => _documents.Select(x => Path.GetFileName(x));

        public int Count => _documents.Count;

        public void AddDocument(string filePath)
        {
            _documents.Add(filePath);
        }

        public void RemoveDocument(string filePath)
        {
            _documents.Remove(filePath);
        }
    }
}
