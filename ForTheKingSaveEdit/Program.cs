using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ForTheKingSaveEdit
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static int Main(params string[] args)
    {
      try
      {
        var parser = new ArgumentsParser(args);

        var inputPath = parser.Get("input");
        var outputPath = parser.Get("output");

        // --unpack --input:"C:\Users\[username]\AppData\LocalLow\IronOak Games\FTK\save\story_2019_9_7_0.run" --output:"C:\Temp\rawsave.json"
        // --pack --input:"C:\Temp\rawsave.json" --output:"C:\Users\[username]\AppData\LocalLow\IronOak Games\FTK\save\story_2019_9_7_0.run" 
        if(parser.ContainsArgument("unpack"))
        {
          byte[] b = File.ReadAllBytes(inputPath);
          string content = GZip.Decompress(b);
          File.WriteAllText(outputPath, JObject.Parse(content).ToString(Formatting.Indented));
          return 0;
        }
        else if(parser.ContainsArgument("pack"))
        {
          var content = File.ReadAllText(inputPath);
          File.WriteAllBytes(outputPath, GZip.Compress(JObject.Parse(content).ToString(Newtonsoft.Json.Formatting.None)));
          return 0;
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex.ToString());
        return 1;
      }

      Application.ThreadException += Application_ThreadException;

      try
      {
        var saveDirectoryPath = args.Length == 1 ? args[0] : Path.Combine(FileUtility.GetLocalLowAppDataPath(), @"IronOak Games\FTK\save");
        if(Directory.Exists(saveDirectoryPath))
        {
          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new MainForm(saveDirectoryPath));
          return 0;
        }
        else
        {
          MessageBox.Show("The save game directory of \"For The King\" does not exist, try running the game first.");
          return 2;
        }
      }
      catch(Exception ex)
      {
        MessageBox.Show($"I messed up, sorry. The following exception occurred: {ex}", "Something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return 1;
      }
    }

    private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
    {
      MessageBox.Show($"Something unexpected went wrong: {e.Exception}", "Something went wrong :(", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }
}
