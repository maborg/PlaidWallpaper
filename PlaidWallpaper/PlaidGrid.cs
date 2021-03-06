﻿using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace PlaidWallpaper
{
  public class PlaidGrid
  {
    public static byte[] CreateGridImage(GridInfo gridInfo, IEnumerable<Color> paletteIe)
    {
        var palette = paletteIe.ToArray();
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

          if (gridInfo.HorizontalLine)
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

    public class GridInfo
    {
      public GridInfo()
      {
      }
      public bool VerticalLine     { get;  set; }
      public bool HorizontalLine { get;  set; }
      public int BoxSize { get; set; }
      public int MaxXCells { get; set; }
      public int MaxYCells { get; set; }

    }

    public static byte[] CreateGridImage(IEnumerable<Color> palette)
      {
          var gridInfo = new GridInfo() //todo add random grindinfo type
          {
              MaxXCells = 16,
              MaxYCells = 5,
              BoxSize = 20,
              VerticalLine = true,
              HorizontalLine = true
          };
        return CreateGridImage(gridInfo, palette);
      }
  }
}