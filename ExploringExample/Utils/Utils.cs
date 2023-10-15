using System.Reflection;

namespace ExploringExample.Utils
{
    public class Utils
    {
        public static string? CurrentWorkingDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)?.Split("/bin")[0];
    }
}