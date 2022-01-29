using System.IO;
using System.Net;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Hostname : ICommand {
    public string Name { get { return "hostname"; } }
    public string Description { get { return "print computer's hostname"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }

    public void Command() {
      Console.WriteLine(Dns.GetHostName());
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
