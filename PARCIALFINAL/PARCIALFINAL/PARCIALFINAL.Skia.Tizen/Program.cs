using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace PARCIALFINAL.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new PARCIALFINAL.App(), args);
            host.Run();
        }
    }
}
