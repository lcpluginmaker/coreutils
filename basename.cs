using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Basename : ICommand {
    public string Name { get { return "basename"; } }
    public string Description { get { return "print name with any leading directory components removed"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      if (_Arguments.Length < 2) {
        Console.WriteLine("you need to provide an argument");
        return;
      }
      Console.WriteLine(Path.GetFileName(_Arguments[1]));
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
