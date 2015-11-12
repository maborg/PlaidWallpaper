using System;
using System.IO;

namespace PlaidWallpaper
{
  internal static class ImageSaver
  {
    public static void SaveImage(string filename, byte[] taskbyte)
    {
      var di = Directory.CreateDirectory(String.Format("{0}\\wallpaper\\plaidwallpaper\\",
        Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));

      FileStream file = new FileStream(Path.Combine(di.FullName, filename), FileMode.Create, FileAccess.Write);
      byte[] bytes = taskbyte;
      file.Write(bytes, 0, bytes.Length);
      file.Close();

    }
  }
}