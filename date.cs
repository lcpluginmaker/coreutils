using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Date : ICommand {
    public string Name { get { return "date"; } }
    public string Description { get { return "print current date and time"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }

    public void Command() {
      Console.WriteLine(DateTime.Now.ToString());
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
