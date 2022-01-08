using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Cat : ICommand {
    public string Name { get { return "cat"; } }
    public string Description { get { return "print contents of a file"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public void Command() {
      if (_InputProperties.Length < 2) {
        Console.WriteLine("you need to provide an argument");
        return;
      }
      try {
        Console.WriteLine(File.ReadAllText(_InputProperties[1]));
      } catch (Exception e) {
        Console.WriteLine("error: " + e.Message);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
