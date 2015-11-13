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
      // long list with all the color palettes in a single list 
      IEnumerable<Color[]> listOfPalettes =_paletteDownloader.DownloadPalette(_transparency, numOfPalette);

      foreach (var singlePalette in listOfPalettes)
      {
        var imgByteList = listOfPalettes.Select(
          palette => PlaidGrid.CreateGridImage(gridInfo, palette)).ToList();
        int i = 0;


        foreach (var bufferByteJpg in imgByteList)
        {
          string filename = string.Format(@"paletteWallpaper_{0}.jpg", (++i));
          ImageSaver.SaveImage(filename, bufferByteJpg);
        }
      }





    }


  }

  internal static class Helper
  {
    /// <summary>
    /// Break a list of items into chunks of a specific size
    /// </summary>
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunksize)
    {
      while (source.Any())
      {
        yield return source.Take(chunksize);
        source = source.Skip(chunksize);
      }
    }
  }
}