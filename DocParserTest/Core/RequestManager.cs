namespace DocParserTest.Core
{
    using DocParserTest.Common;
    using DocParserTest.Models;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public class RequestManager : BaseManager, IRequestManager
    {
        private readonly HttpClient client;

        public RequestManager()
        {
            this.client = new HttpClient();

            this.SetHeaders();
        }

        public async Task<IEnumerable<Parser>> GetParsersRequest()
        {
            HttpResponseMessage response = await this.client.GetAsync("parsers");
            string jsonStrParsers = await response.Content.ReadAsStringAsync();
            
            base.SetParsers(jsonStrParsers);

            return base.Parsers;
        }

        public async Task UploadFileByStream(string parserId, KeyValuePair<string, string> fileData)
        {
            MultipartFormDataContent form = new MultipartFormDataContent
            {
                { new StringContent(fileData.Value), "file_content" },
                { new StringContent(fileData.Key), "file_name" }
            };

            HttpResponseMessage response = await this.client.PostAsync($"document/upload/{parserId}", form);
            string data = await response.Content.ReadAsStringAsync();

            Debug.WriteLine(data);
        }

        private void SetHeaders()
        {
            this.client.BaseAddress = new Uri(Constants.URI_DOCPARSER);

            this.client.DefaultRequestHeaders.Accept.Clear();

            this.client.DefaultRequestHeaders.Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            this.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Constants.API_SECRET);
        }
    }
}
