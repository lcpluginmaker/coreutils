using System.IO;
using System.Net;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Hostname : ICommand {
    public string Name { get { return "hostname"; } }
    public string Description { get { return "print computer's hostname"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }

    public void Command() {
      Console.WriteLine(Dns.GetHostName());
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
