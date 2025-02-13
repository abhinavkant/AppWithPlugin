using PluginBase;

namespace FilePlugin;

public class FileCommand : ICommand
{
    public string Name { get => "File"; }
    public string Description { get => "Displays File message."; }

    public int Execute()
    {
        Console.WriteLine("File !!!");
        return 0;
    }
}
