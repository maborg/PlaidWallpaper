using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace PlaidWallpaper
{
    public class PlaidGridRandom
    {

        static System.Random rand = new System.Random();

        public static Bitmap CreateGridImage(PlaidGrid.GridInfo gridInfo, IEnumerable<Color> paletteIe)
        {
            var palette = paletteIe.ToArray();
            var bmp = new Bitmap(gridInfo.MaxXCells * gridInfo.BoxSize + 1, gridInfo.MaxYCells * gridInfo.BoxSize + 1);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                Pen pen = new Pen(palette.First())
                {
                    Color = palette.First(),
                    Width = gridInfo.BoxSize
                };
                g.Clear(palette[0]);
                if (gridInfo.VerticalLine)
                    //Draw vert lines
                    for (int i = 0; i <= gridInfo.MaxXCells; i++)
                    {
                        pen.Color = palette[i % (palette.Length)];
                        g.DrawLine(pen, (i * gridInfo.BoxSize) + rand.Next(-gridInfo.BoxSize, gridInfo.BoxSize), 0, i * gridInfo.BoxSize, gridInfo.BoxSize * gridInfo.MaxYCells + 1);
                    }
                if (gridInfo.HorizontalLine)
                    //Draw oriz lines            
                    for (int i = 0; i <= gridInfo.MaxYCells; i++)
                    {
                        pen.Color = palette[i % (palette.Length)];
                        g.DrawLine(pen, 0, (i * gridInfo.BoxSize) + rand.Next(-gridInfo.BoxSize, gridInfo.BoxSize), gridInfo.BoxSize * gridInfo.MaxXCells + 1, i * gridInfo.BoxSize);
                    }

                if (gridInfo.VerticalLine)
                    //Draw vert lines
                    for (int i = gridInfo.MaxXCells-1; i >=0 ; i--)
                    {
                        pen.Color = palette[i % (palette.Length)];
                        g.DrawLine(pen, (i * gridInfo.BoxSize) + rand.Next(-gridInfo.BoxSize, gridInfo.BoxSize), 0, i * gridInfo.BoxSize, gridInfo.BoxSize * gridInfo.MaxYCells + 1);
                    }

                if (gridInfo.HorizontalLine)
                    //Draw oriz lines            
                    for (int i = gridInfo.MaxYCells-1; i >=0 ; i--)
                    {
                        pen.Color = palette[i % (palette.Length)];
                        g.DrawLine(pen, 0, (i * gridInfo.BoxSize) + rand.Next(-gridInfo.BoxSize, gridInfo.BoxSize), gridInfo.BoxSize * gridInfo.MaxXCells + 1, i * gridInfo.BoxSize);
                    }


                return bmp;
            }



        }

        public class GridInfo
        {
            public GridInfo()
            {
            }
            public bool VerticalLine { get; set; }
            public bool HorizontalLine { get; set; }
            public int BoxSize { get; set; }
            public int MaxXCells { get; set; }
            public int MaxYCells { get; set; }

        }

        public static Bitmap CreateGridImage(IEnumerable<Color> palette)
        {
            var gridInfo = new PlaidGrid.GridInfo() //todo add random grindinfo type
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
