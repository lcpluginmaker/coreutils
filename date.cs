using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Date : ICommand {
    public string Name { get { return "date"; } }
    public string Description { get { return "print current date and time"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }

    public void Command() {
      Console.WriteLine(DateTime.Now.ToString());
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
