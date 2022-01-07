using System.IO;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Echo : ICommand {
    public string Name { get { return "echo"; } }
    public string Description { get { return "print the given parameters to the screen"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }
    public void Command() {
      for (int i = 1; i < _InputProperties.Length; i++) {
        Console.Write(InputProperties[i] + " ");
      }
      Console.Write("\n");
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
