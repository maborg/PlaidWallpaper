using System;

using System.Windows.Forms;

namespace PlaidWallpaperWinForm
{
  public partial class PlaidForm : Form
  {
    public PlaidForm()
    {
      InitializeComponent();
    }

    private void buttonDoThePlaid_Click(object sender, EventArgs e)
    {
      var plaidWallpaper = new PlaidWallpaper
      {
        PaletteDownloader = new PaletteDownloader()
      };

      var a = plaidWallpaper.DoThePlaid();
    }


  }
}
