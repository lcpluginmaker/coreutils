using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Clear : ICommand {
    public string Name { get { return "clear"; } }
    public string Description { get { return "clear the screen"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public void Command() {
      Console.Clear();
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
