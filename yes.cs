using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Yes : ICommand {
    public string Name { get { return "yes"; } }
    public string Description { get { return "output a string repeatedly until killed"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      string str;
      if (_Arguments.Length < 2) {
        str = "y";
      } else {
        str = _Arguments[1];
      }
      while (true) {
        Console.WriteLine(str);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
