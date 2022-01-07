using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Yes : ICommand {
    public string Name { get { return "yes"; } }
    public string Description { get { return "output a string repeatedly until killed"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public void Command() {
      string str;
      if (_InputProperties.Length < 2) {
        str = "y";
      } else {
        str = _InputProperties[1];
      }
      while (true) {
        Console.WriteLine(str);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
