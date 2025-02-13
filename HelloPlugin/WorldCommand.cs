using PluginBase;

namespace HelloPlugin
{
    public class WorldCommand : ICommand
    {
        public string Name { get => "world"; }
        public string Description { get => "Displays world message."; }

        public int Execute()
        {
            Console.WriteLine("world !!!");
            return 0;
        }
    }
}