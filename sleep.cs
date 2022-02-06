using System.IO;
using System.Threading;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Sleep : ICommand {
    public string Name { get { return "sleep"; } }
    public string Description { get { return "do nothing for given number of seconds"; } }
    public Action CommandFunktion { get { return () => Command(); } }
    private string[] _InputProperties;
    public string[] InputProperties { get { return _InputProperties; } set { _InputProperties = value; } }

    public void Command() {
      int dur;
      if (_InputProperties.Length < 2) {
        dur = 1;
      } else {
        try {
          dur = Int32.Parse(_InputProperties[1]);
        } catch (Exception e) {
          Console.WriteLine("invalid number provided");
          return;
        }
      }
      Thread.Sleep(dur * 1000);
    }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
