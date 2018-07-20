namespace DocParserTest.Core
{
    using DocParserTest.Models;
    using System.Collections.Generic;

    public interface IFileManager
    {
        IEnumerable<Document> Documents { get; }
        KeyValuePair<string, string> SpecBase64 { get; }
        KeyValuePair<string, string> CertBase64 { get; }
        // TODO: Add DI
        void AddFileType(string fileType, string fileName, string fileFullPath);
    }
}
