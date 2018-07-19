using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace PlaidWallpaper
{
    public class PaletteDownloader
    {
        private readonly Random _random = new Random(232240);
        private readonly string colourLoverUrl = @"http://www.colourlovers.com/api/palettes?resultOffset={0}&numResults={1}&orderCol=numVote&keywords={2}&sortBy=DESC";

        public async Task<IEnumerable<Color>> DownloadPaletteAsync(uint alpha)
        {
            var url = string.Format(colourLoverUrl, _random.Next(0, 100));


            Task<string> xmlString = new WebClient().DownloadStringTaskAsync(url);

            var s = (await xmlString);

            var x = XDocument.Parse(s, LoadOptions.None);

            var palette = x.XPathSelectElement("//palette/colors")
              .Elements()
              .Select(c => c.Value)
              .Select(c => Int32.Parse(c, System.Globalization.NumberStyles.HexNumber))
              .Select(c => Color.FromArgb((int)(c | alpha)));
            return palette;
        }

        internal IEnumerable<Color[]> DownloadPalette(uint _transparency, uint numOfPalette, object keywords)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Color[]> DownloadPalette(uint alpha, uint numOfPalette, string keywords)
        {
            var url = string.Format(colourLoverUrl, _random.Next(0, 100), numOfPalette, keywords);

            string xmlString = new WebClient().DownloadString(url);

            var x = XDocument.Parse(xmlString, LoadOptions.None);
            var chunkPalette = x.XPathSelectElements("//colors");
            var listArrColor = new List<System.Drawing.Color[]>();
            while (chunkPalette.Any())
            {
                var p = chunkPalette.Take(1);
                var arrayColor = p.Elements()
                  .Select(c => c.Value)
                  .Select(c => Int32.Parse(c, System.Globalization.NumberStyles.HexNumber))
                  .Select(c => System.Drawing.Color.FromArgb((int)(c | alpha)));
                listArrColor.Add(arrayColor.ToArray());
                chunkPalette = chunkPalette.Skip(1);
            }
            return listArrColor;
        }
    }
}