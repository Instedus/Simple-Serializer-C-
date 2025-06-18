using System;
using ConsoleApp1;


internal class Program
{
    static string path;
    public static void Main(string[] args)
    {
        //SimpleJsonSave();
        //SimpleBinarySave();
        //SimpleXmlSave();
    }

    static void SimpleBinarySave()
    {
        path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Save.dat");

        using (BinarySerialize bs = new())
        {
            Data data = new("1", "2", "3");

            bs.Save(path, data);

            Data newData = bs.Load<Data>(path);

            Console.WriteLine(newData.title + newData.num + newData.description);
        }
    }

    static void SimpleJsonSave()
    {
        path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Save.json");

        using (JsonSerialize js = new())
        {
            Data data = new("5", "6", "7");

            js.Save(path, data);

            Data newData = js.Load<Data>(path);

            Console.WriteLine(newData.title + newData.num + newData.description);
        }
    }

    static void SimpleXmlSave()
    {
        path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Save.xml");

        using (XmlSerialize xs = new())
        {
            Data data = new("8", "9", "0");

            xs.Save<Data>(path, data);

            Data newData = xs.Load<Data>(path);

            Console.WriteLine(newData.title + newData.num + newData.description);
        }
    }
}
