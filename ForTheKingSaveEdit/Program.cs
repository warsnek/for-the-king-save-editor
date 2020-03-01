using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTheKingSaveEdit
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(params string[] args)
    {
      Application.ThreadException += Application_ThreadException;

      try
      {
        var saveDirectoryPath = args.Length == 1 ? args[0] : Path.Combine(FileUtility.GetLocalLowAppDataPath(), @"IronOak Games\FTK\save");
        if(Directory.Exists(saveDirectoryPath))
        {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new MainForm(saveDirectoryPath));
        }
        else
        {
          MessageBox.Show("The save game directory of \"For The King\" does not exist, try running the game first.");
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show($"I messed up, sorry. The following exception occurred: {ex}", "Something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
      MessageBox.Show($"Something unexpected went wrong: {e.Exception}", "Something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
