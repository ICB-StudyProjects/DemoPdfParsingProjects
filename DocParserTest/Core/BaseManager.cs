namespace DocParserTest.Core
{
    using DocParserTest.Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class BaseManager : IBaseManager
    {
        private ICollection<Parser> parsers;

        public BaseManager()
        {
            parsers = new HashSet<Parser>();
        }

        public IEnumerable<Parser> Parsers => this.parsers;

        public void SetParsers(string jsonStrParsers)
        {
            this.parsers = JsonConvert.DeserializeObject<ICollection<Parser>>(jsonStrParsers);
        }
    }
}
