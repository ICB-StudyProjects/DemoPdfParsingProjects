namespace DocParserTest.Core
{
    using DocParserTest.Models;
    using System.Collections.Generic;

    public interface IBaseManager
    {
        IEnumerable<Parser> Parsers { get; }
        void SetParsers(string parsers);
    }
}
