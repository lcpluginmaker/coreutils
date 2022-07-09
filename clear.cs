using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Clear : ICommand {
    public string Name { get { return "clear"; } }
    public string Description { get { return "clear the screen"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      Console.Clear();
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
