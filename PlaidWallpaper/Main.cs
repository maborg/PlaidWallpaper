namespace it.to.maborg
{
  class MainClass
  {
    static void Main(string[] args)
    {
        var plaidWallpaper = new PlaidWallpaper
        {
            PaletteDownloader = new PaletteDownloader()
        };

        var a = plaidWallpaper.DoThePlaid();

      
    }
  }
}
