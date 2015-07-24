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
    public async Task<IEnumerable<Color>> DownloadPaletteAsync(Random r, uint alpha)
    {
      var url = String.Format("http://www.colourlovers.com/api/palettes?resultOffset={0}&numResults=1&orderCol=numVote&sortBy=DESC", r.Next(0, 100));

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
  }
}