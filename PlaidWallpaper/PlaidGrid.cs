using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace it.to.maborg
{
  class PlaidGrid
  {
    public static byte[] CreateGridImage(GridInfo gridInfo, IEnumerable<Color> paletteIE)
    {
        var palette = paletteIE.ToArray();
      using (var bmp = new Bitmap(gridInfo.MaxXCells * gridInfo.BoxSize + 1, gridInfo.MaxYCells * gridInfo.BoxSize + 1))
      {
        using (Graphics g = Graphics.FromImage(bmp))
        {
          g.Clear(Color.White);
          Pen pen = new Pen(palette.First())
          {
              Color = palette.First(),
            Width = gridInfo.BoxSize
          };

          if (gridInfo.VerticalLine)
          //Draw vert lines
          for (int i = 0; i <= gridInfo.MaxXCells; i++)
          {
            pen.Color = palette[i % (palette.Length)];
            g.DrawLine(pen, (i * gridInfo.BoxSize), 0, i * gridInfo.BoxSize, gridInfo.BoxSize * gridInfo.MaxYCells + 1);
          }

          if (gridInfo.OrizzontalLine)
          //Draw oriz lines            
          for (int i = 0; i <= gridInfo.MaxYCells; i++)
          {
            pen.Color = palette[i % (palette.Length)];
            g.DrawLine(pen, 0, (i * gridInfo.BoxSize), gridInfo.BoxSize * gridInfo.MaxXCells + 1, i * gridInfo.BoxSize);
          }
        }

        var memStream = new MemoryStream();
        bmp.Save(memStream, ImageFormat.Png);
        return memStream.ToArray();
      }
    }

    internal class GridInfo
    {
      public GridInfo()
      {
      }
      public bool VerticalLine     { get;  set; }
      public bool OrizzontalLine { get;  set; }
      public int BoxSize { get; set; }
      public int MaxXCells { get; set; }
      public int MaxYCells { get; set; }

    }

    public static byte[] CreateGridImage(IEnumerable<Color> palette)
      {
          var gridInfo = new PlaidGrid.GridInfo() //todo add random grindinfo type
          {
              MaxXCells = 5,
              MaxYCells = 5,
              BoxSize = 20,
              VerticalLine = true,
              OrizzontalLine = true
          };
        return CreateGridImage(gridInfo, palette);
      }
  }
}