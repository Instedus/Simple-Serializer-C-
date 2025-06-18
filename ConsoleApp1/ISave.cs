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

        T Load<T>(string path);
    }
}
