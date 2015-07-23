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

      var palette = new[] {
        _palette.DownloadPaletteAsync(r, 0xaB000000), 
        _palette.DownloadPaletteAsync(r, 0xaA000000),
        _palette.DownloadPaletteAsync(r, 0xa3000000),
        _palette.DownloadPaletteAsync(r, 0xa1000000),
        _palette.DownloadPaletteAsync(r, 0xa2000000),
        _palette.DownloadPaletteAsync(r, 0xa3000000),
        _palette.DownloadPaletteAsync(r, 0xa4000000),
        _palette.DownloadPaletteAsync(r, 0xa5000000),
        _palette.DownloadPaletteAsync(r, 0xa6000000)
      
      };

      var ImgByteList = palette
        .Select(async (p) => PlaidGrid.CreateGridImage(new PlaidGrid.GridInfo()
        { MaxXCells = 5,
          MaxYCells = 5,
          BoxSize = r.Next(1, 30) + r.Next(1, 30),
          VerticalLine = true,
          Palette = (await p).ToArray()})).ToList();

      int i = 0;

      foreach (Task<byte[]> taskbyte in ImgByteList)
      {
        FileStream file = new FileStream(string.Format("C:\\Users\\marco.borgna\\Pictures\\wallpaper\\PlaidWallpaper\\paletteWallpaper_{0}.jpg", (++i)), FileMode.Create, FileAccess.Write);
        byte[] bytes=await taskbyte;
        file.Write(bytes, 0, bytes.Length);
      }


      return true;
    }
  }
}