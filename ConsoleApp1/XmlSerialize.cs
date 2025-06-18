using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class XmlSerialize : ISave
    {
        private bool disposedValue;

        public T Load<T>(string path)
        {
            try
            {
                using (FileStream stream = new(path, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new(typeof(T));

                    return (T)serializer.Deserialize(stream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            object nothin = null;

            return (T)nothin;
        }

        public void Save<T>(string path, T obj) where T : class
        {
            try
            {
                using (FileStream stream = new(path, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new(typeof(T));

                    serializer.Serialize(stream, obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Save(string path, object data)
        {
            throw new NotImplementedException();
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
        // ~XmlSerializer()
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
