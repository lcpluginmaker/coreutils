using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Basename : ICommand {
    public string Name { get { return "basename"; } }
    public string Description { get { return "print name with any leading directory components removed"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public void Command() {
      if (_InputProperties.Length < 2) {
        Console.WriteLine("you need to provide an argument");
        return;
      }
      Console.WriteLine(Path.GetFileName(_InputProperties[1]));
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
