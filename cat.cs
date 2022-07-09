using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Cat : ICommand {
    public string Name { get { return "cat"; } }
    public string Description { get { return "print contents of a file"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      if (_Arguments.Length < 2) {
        Console.WriteLine("you need to provide an argument");
        return;
      }
      try {
        Console.WriteLine(File.ReadAllText(_Arguments[1]));
      } catch (Exception e) {
        Console.WriteLine("error: " + e.Message);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
