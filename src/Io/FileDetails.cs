using System;
using System.IO;

namespace Io
{
    public class FileDetails
    {
        private readonly string _filePath;
        private string _filename;
        private DateTime? _lastModified;
        private FileInfo _info;

        public FileDetails(string filePath)
        {
            _filePath = filePath;
        }

        public string Filename
        {
            get { return _filename ?? (_filename = Path.GetFileName(_filePath)); }
        }

        public DateTime LastModified
        {
            get { return _lastModified ?? (_lastModified = Info.LastWriteTimeUtc).Value; }
        }

        private FileInfo Info
        {
            get { return _info ?? (_info = new FileInfo(_filePath)); }
        }
    }
}
