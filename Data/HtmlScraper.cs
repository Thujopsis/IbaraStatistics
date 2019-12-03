using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using AngleSharp.Html.Parser;
using AngleSharp.Html.Dom;

namespace IbaraStatistics.Data
{
    public class HtmlScraper : IDisposable
    {
        public ushort DelayMS { get; set; } = 1000;

        private static HttpClient client = new HttpClient();
        private HtmlParser parser = new HtmlParser();
        public HtmlScraper()
        {
        }
        public HtmlScraper(ushort delayMS)
        {
            DelayMS = delayMS;
        }

        public async Task<IHtmlDocument> Scrape(string url)
        {
            HttpResponseMessage response = await client.GetAsync(new Uri(url)).ConfigureAwait(false);
            using Stream stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            IHtmlDocument doc = await parser.ParseDocumentAsync(stream).ConfigureAwait(false);
            RefreshDelay();
            return doc;
        }

        private Task previousDelayTask = Task.CompletedTask;
        private void RefreshDelay()
        {
            previousDelayTask = Task.Delay(DelayMS);
        }
        public async Task WaitDelay()
        {
            await previousDelayTask.ConfigureAwait(false);
        }

#region disposing pattern
        bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                //client.Dispose();
            }

            disposed = true;
        }

        ~HtmlScraper()
        {
            Dispose(false);
        }
#endregion
    }
}
