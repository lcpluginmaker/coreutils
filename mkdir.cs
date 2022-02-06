using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Mkdir : ICommand {
    public string Name { get { return "mkdir"; } }
    public string Description { get { return "create a directory"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public IData data = new ConsoleData();

    public void Command() {
      if (_InputProperties.Length < 2) {
        Console.WriteLine("you need to provide at least one directory name");
        return;
      }
      for (int i = 1; i < _InputProperties.Length; i++) {
        mkdir(_InputProperties[i]);
        Console.Write("\n");
      }
    }

    private void mkdir(string directory) {
      try {
        Directory.CreateDirectory(directory);
        Console.WriteLine("created " + directory);
      } catch (Exception e) {
        Console.WriteLine("error: " + e.Message);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
