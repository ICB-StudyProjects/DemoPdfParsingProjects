namespace DocParserTest.Models
{
    public class Document
    {
        public string Name, CertType, Base64Str;
        public string Id, FileSize;

        public Document(string name, string type, string base64)
        {
            Name = name;
            CertType = type;
            Base64Str = base64;
        }

        public void SetDocParserReturnData(string id, string fileSize)
        {
            this.Id = id;
            this.FileSize = fileSize;
        }
    }
}
