using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Ls : ICommand {
    public string Name { get { return "ls"; } }
    public string Description { get { return "list contents of a folder"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public IData data = new ConsoleData();

    public void Command() {
      if (_InputProperties.Length < 2) {
        ls(data.SavePath);
        return;
      }
      for (int i = 1; i < _InputProperties.Length; i++) {
        ls(_InputProperties[i]);
        Console.Write("\n");
      }
    }

    private void ls(string directory) {
      Console.WriteLine(directory + ":");
      try {
        foreach (string filename in Directory.GetDirectories(directory)) {
          Console.WriteLine(Path.GetFileName(filename) + "/");
        }
        foreach (string filename in Directory.GetFiles(directory)) {
          Console.WriteLine(Path.GetFileName(filename));
        }
      } catch (Exception e) {
        Console.WriteLine("error: " + e.Message);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
