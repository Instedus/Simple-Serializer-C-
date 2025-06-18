using System;
using ConsoleApp1;


internal class Program
{
    static string path;
    public static void Main(string[] args)
    {
        using (BinarySerializer bs = new())
        {
            //bs.Save();
            //bs.Load();
        }

        using (JsonSerializer js = new())
        {
            //js.Save();
            //js.Load();
        }
    }
}
