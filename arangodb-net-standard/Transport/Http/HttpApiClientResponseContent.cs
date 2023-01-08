﻿using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ArangoDBNetStandard.Transport.Http
{
    public class HttpApiClientResponseContent : IApiClientResponseContent
    {
        private readonly HttpContent content;

        public HttpApiClientResponseContent(HttpContent content)
        {
            this.content = content;
        }

        public HttpContentHeaders Headers => content.Headers;

        public async Task<Stream> ReadAsStreamAsync()
        {
            return await content.ReadAsStreamAsync().ConfigureAwait(false);
        }

        public async Task<string> ReadAsStringAsync()
        {
            return await content.ReadAsStringAsync().ConfigureAwait(false);
        }
    }
}
