using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace it.to.maborg
{
  class PaletteDownloader
  {
      private readonly Random _random = new Random(2348240);
      private readonly string colourLoverUrl = @"http://www.colourlovers.com/api/palettes?resultOffset={0}&numResults=3&orderCol=numVote&sortBy=DESC";

      public async Task<IEnumerable<Color>> DownloadPaletteAsync( uint alpha)
    {
        var url = string.Format(colourLoverUrl, _random.Next(0, 100));
          

      Task<string> xmlString = new WebClient().DownloadStringTaskAsync(url);

      var s = (await xmlString);

      var x = XDocument.Parse(s, LoadOptions.None);

      var palette = x.XPathSelectElement("//palette/colors")
        .Elements()
        .Select(c => c.Value)
        .Select(c => System.Int32.Parse(c, System.Globalization.NumberStyles.HexNumber))
        .Select(c => Color.FromArgb((int)(c | alpha)));
      return palette;
    }

      public IEnumerable<Color> DownloadPalette(uint alpha)
      {
          var url = string.Format(colourLoverUrl, _random.Next(0, 100));

          string xmlString = new WebClient().DownloadString(url);

          var x = XDocument.Parse(xmlString, LoadOptions.None);

          var palette = x.XPathSelectElement("//palette/colors")
            .Elements()
            .Select(c => c.Value)
            .Select(c => System.Int32.Parse(c, System.Globalization.NumberStyles.HexNumber))
            .Select(c => Color.FromArgb((int)(c | alpha)));
          return palette;
      }
  }
}