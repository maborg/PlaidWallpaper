using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace it.to.maborg
{
  class PlaidGrid
  {
    public static byte[] CreateGridImage(GridInfo gridInfo)
    {
      using (var bmp = new Bitmap(gridInfo.MaxXCells * gridInfo.BoxSize + 1, gridInfo.MaxYCells * gridInfo.BoxSize + 1))
      {
        using (Graphics g = Graphics.FromImage(bmp))
        {
          g.Clear(Color.White);
          Pen pen = new Pen(gridInfo.Palette[0])
          {
            Color = gridInfo.Palette[0],
            Width = gridInfo.BoxSize
          };

          if (gridInfo.VerticalLine)
          //Draw vert lines
          for (int i = 0; i <= gridInfo.MaxXCells; i++)
          {
            pen.Color = gridInfo.Palette[i % (gridInfo.Palette.Length)];
            g.DrawLine(pen, (i * gridInfo.BoxSize), 0, i * gridInfo.BoxSize, gridInfo.BoxSize * gridInfo.MaxYCells + 1);
          }

          if (gridInfo.OrizzontalLine)
          //Draw oriz lines            
          for (int i = 0; i <= gridInfo.MaxYCells; i++)
          {
            pen.Color = gridInfo.Palette[i % (gridInfo.Palette.Length)];
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
      public Color[] Palette { get; set; }
    }
  }
}