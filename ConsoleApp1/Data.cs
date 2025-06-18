using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [System.Serializable]
    public class Data
    {
        public readonly string title;

        public readonly string description;

        public readonly string num;

        public Data(string title, string num, string description)
        {
            this.title = title;
            this.num = num;
            this.description = description;
        }

        public Data()
        {
            
        }
    }
}
