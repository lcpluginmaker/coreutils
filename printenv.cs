using System.IO;
using System.Collections;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Printenv : ICommand {
    public string Name { get { return "printenv"; } }
    public string Description { get { return "print the environment"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }
    public void Command() {
      foreach (DictionaryEntry de in Environment.GetEnvironmentVariables()) {
        Console.WriteLine("{0}={1}", de.Key, de.Value);
      }
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
