using System.IO;
using System.Threading;
using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class Sleep : ICommand {
    public string Name { get { return "sleep"; } }
    public string Description { get { return "do nothing for given number of seconds"; } }
    public Action CommandFunction { get { return () => Command(); } }
    public Action HelpFunction { get { return () => Console.WriteLine("not available"); } }
    private string[] _Arguments;
    public string[] Arguments { get { return _Arguments; } set { _Arguments = value; } }

    public void Command() {
      int dur;
      if (_Arguments.Length < 2) {
        dur = 1;
      } else {
        try {
          dur = Int32.Parse(_Arguments[1]);
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
