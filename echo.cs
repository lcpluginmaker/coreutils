using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Echo : ICommand {
    public string Name { get { return "echo"; } }
    public string Description { get { return "print the given parameters to the screen"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      for (int i = 1; i < _Arguments.Length; i++) {
        Console.Write(Arguments[i] + " ");
      }
      Console.Write("\n");
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
