using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploringExample.Models
{
    public class FileReading
    {
        public static (bool Success, string[] Lines, int LineCount) ReadFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                return (true, lines, lines.Length);
            }
            catch (Exception)
            {
                return (false, Array.Empty<string>(), 0);
            }
            
        }
    }
}