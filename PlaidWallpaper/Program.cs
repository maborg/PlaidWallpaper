using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace it.to.maborg
{
  class Program
  {
    static void Main(string[] args)
    {
      var a= new PlaidWallpaper().DoThePlaid();
      a.Wait();
    }
  }
}
