﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaidWallpaperWinForm;

namespace PlaidWallpaper
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.1
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new PlaidForm());
    }
  }
}