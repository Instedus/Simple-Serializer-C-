using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BinarySerializer : ISave
    {
        private bool disposedValue;

        public T Load<T>(string path)
        {
            using (FileStream stream = new(path, FileMode.Open))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    return (T)formatter.Deserialize(stream);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }

                object nothing = null;

                return (T)nothing;
            }
        }

        public void Save(string path, object data)
        {
            using (FileStream stream = new(path, FileMode.OpenOrCreate))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    formatter.Serialize(stream, data);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        // // TODO: переопределить метод завершения, только если "Dispose(bool disposing)" содержит код для освобождения неуправляемых ресурсов
        // ~BinarySerializer()
        // {
        //     // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Не изменяйте этот код. Разместите код очистки в методе "Dispose(bool disposing)".
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
