namespace DocParserTest.Core
{
    using DocParserTest.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRequestManager : IBaseManager
    {
        Task<IEnumerable<Parser>> GetParsersRequest();

        Task UploadFileByStream(string parserId, KeyValuePair<string, string> fileData);
    }
}
