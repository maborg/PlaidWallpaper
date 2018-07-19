using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PlaidWallpaper
{
    public class PlaidWallpaper
    {
        private readonly PaletteDownloader _paletteDownloader = new PaletteDownloader();

        private readonly uint _transparency = 0xAA000000;

        public void DoThePlaid(PlaidGrid.GridInfo gridInfo, uint numOfPalette, string keywords)
        {

            // long list with all the color palettes in a single list 
            IEnumerable<Color[]> listOfPalettes = _paletteDownloader.DownloadPalette(_transparency, numOfPalette, keywords);
           
            if (listOfPalettes.Count() ==0)
                System.Windows.Forms.MessageBox.Show("No palette avaliables for " + keywords);

            var imgByteList = listOfPalettes.Select(
                palette => PlaidGridRandom.CreateGridImage(gridInfo, palette)
              ).ToList();
            int i = 0;
            foreach (var bmp in imgByteList)
            {
                string filename = string.Format(@"paletteWallpaper_{0}.png", (++i));
                
                var memStream = new MemoryStream();
                bmp.Save(memStream, ImageFormat.Png);
             
                ImageSaver.SaveImage(filename, memStream.ToArray());
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