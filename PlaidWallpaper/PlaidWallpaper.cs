using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace it.to.maborg
{
  class PlaidWallpaper
  {
    private readonly PaletteDownloader _palette = new PaletteDownloader();

    public async Task<bool> DoThePlaid()
    {
      var r = new Random();

      var palette = new[]
      {
        _palette.DownloadPaletteAsync(r, 0xAA000000),
        _palette.DownloadPaletteAsync(r, 0xFF000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xFF000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
        _palette.DownloadPaletteAsync(r, 0xBB000000),
      };

      int j = 0;
      int numloops = 5;

      do
      {
        var imgByteList = palette.Select(async (p, index) => PlaidGrid.CreateGridImage(
                                                              new PlaidGrid.GridInfo()
                                                                {
                                                                  MaxXCells = r.Next(3, 25),
                                                                  MaxYCells = r.Next(3, 25),
                                                                  BoxSize = r.Next(3, 25) * r.Next(3, 6),
                                                                  VerticalLine = index % 3 == 1,,
                                                                  OrizzontalLine = index % 5 == 1,
                                                                  Palette =  (await p).ToArray()
                                                                }
                                                            )).ToList();

        int i = 0;

        foreach (Task<byte[]> taskbyte in imgByteList)
        {
          string filename = string.Format(@"{0}\wallpaper\plaidwallpaper\paletteWallpaper_{2}_{1}.jpg", 
            Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures), (++i), j);
          FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
          byte[] bytes = await taskbyte;
          file.Write(bytes, 0, bytes.Length);
        }
        j++;
      } while (j<numloops);
      return true;
    }

  }
}