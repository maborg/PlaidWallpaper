using System;

using System.Windows.Forms;
using PlaidWallpaper;

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

      try
      {
        var gridInfo = new PlaidGrid.GridInfo()
                      {

                        BoxSize = int.Parse(tbBoxSize.Text),
                        MaxXCells = int.Parse(tbMaxXCells.Text),
                        MaxYCells = int.Parse(tbMaxYCells.Text),
                        HorizontalLine = cbHorizontalLine.Checked,
                        VerticalLine = cbVerticalLine.Checked,

                      };

        var plaidWallpaper = new PlaidWallpaper.PlaidWallpaper();
        plaidWallpaper.DoThePlaid(gridInfo, uint.Parse(tbWallpaperNumber.Text));

      }
      catch (FormatException)
      {
        MessageBox.Show("One field seem to be wrong. :( ");

      }
    }
  }
}
