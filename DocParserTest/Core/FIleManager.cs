namespace DocParserTest.Core
{
    using DocParserTest.Common;
    using DocParserTest.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileManager : IFileManager
    {
        private ICollection<Document> documents; 
        public KeyValuePair<string, string> SpecBase64 { get; private set; }
        public KeyValuePair<string, string> CertBase64 { get; private set; }

        public IEnumerable<Document> Documents => this.documents;

        public void AddFileType(string fileType, string fileName, string fileFullPath)
        {
            Byte[] bytes = File.ReadAllBytes(fileFullPath);
            string file = Convert.ToBase64String(bytes);
            
            if (fileType == Constants.SPECIFICATION)
            {
                this.SpecBase64 = new KeyValuePair<string, string>(fileName, file);
            }
            else if (fileType == Constants.CERTIFICATE)
            {
                this.CertBase64 = new KeyValuePair<string, string>(fileName, file);
            }

            this.documents.Add(new Document(fileName, fileType, file));
        }
    }
}
