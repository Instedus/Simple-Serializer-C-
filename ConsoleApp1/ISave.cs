using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ISave : IDisposable
    {
        void Save(string path, object data);

        void Save<T>(string path, T obj) where T: class;
        T Load<T>(string path);
    }
}
