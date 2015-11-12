using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace PlaidWallpaper
{
  internal interface IPaletteDownloader
  {
    Task<IEnumerable<Color>> DownloadPaletteAsync( uint alpha);
    IEnumerable<Color> DownloadPalette(uint alpha, uint numOfPalette);
  }
}