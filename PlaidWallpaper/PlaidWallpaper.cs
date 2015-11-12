using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PlaidWallpaper
{
  public class PlaidWallpaper
  {
    private readonly PaletteDownloader _paletteDownloader = new PaletteDownloader();

    private readonly uint _transparency = 0xAA000000;

    public void DoThePlaid(PlaidGrid.GridInfo gridInfo, uint numOfPalette)
    {
      IEnumerable<Color>[] listOfPalettes = {
        _paletteDownloader.DownloadPalette(_transparency, numOfPalette),
      };

      var imgByteList = listOfPalettes.Select(palette => PlaidGrid.CreateGridImage(gridInfo, palette)).ToList();

      int i = 0;


      foreach (var bufferByteJpg in imgByteList)
      {
        string filename = string.Format(@"paletteWallpaper_{0}.jpg", (++i));
        ImageSaver.SaveImage(filename, bufferByteJpg);
      }



    }
  }
}