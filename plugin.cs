using ILeoConsole;
using ILeoConsole.Plugin;
using ILeoConsole.Core;

namespace LeoConsole_ExamplePlugin {
  public class ConsoleData : IData {
    public static User _User;
    public User User { get { return _User; } set { _User = value; } }
    public static string _SavePath;
    public string SavePath { get { return _SavePath; } set { _SavePath = value; } }
    public static string _DownloadPath;
    public string DownloadPath { get { return _DownloadPath; } set { _DownloadPath = value; } }
    public static string _Version;
    public string Version { get { return _Version; } set { _Version = value; } }
    public static string _CurrentWorkingPath;
    public string CurrentWorkingPath { get { return _CurrentWorkingPath; } set { _CurrentWorkingPath = value; } }
  }
  
  public class ExamplePlugin : IPlugin {
    public string Name { get { return "coreutils"; } }
  
    public string Explanation { get { return "very basic implementation of some Unix coreutils"; } }
  
    private IData _data;
    public IData data { get { return _data; } set { _data = value; } }
  
    private List<ICommand> _Commands;
    public List<ICommand> Commands { get { return _Commands; } set { _Commands = value; } }
  
    public void PluginInit(){
      _data = new ConsoleData();
      _Commands = new List<ICommand>();
    }

    public void RegisterCommands() {
      _Commands = new List<ICommand>();
      _Commands.Add(new Basename());
      _Commands.Add(new Cat());
      _Commands.Add(new Date());
      _Commands.Add(new Clear());
      _Commands.Add(new Echo());
      _Commands.Add(new Hostname());
      _Commands.Add(new Printenv());
      _Commands.Add(new Sleep());
      _Commands.Add(new Yes());
    }

    public void PluginMain() { }
    public void PluginShutdown() { }
  }
}

// vim: tabstop=2 softtabstop=2 shiftwidth=2 expandtab
