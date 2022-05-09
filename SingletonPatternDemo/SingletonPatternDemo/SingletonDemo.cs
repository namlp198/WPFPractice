using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPatternDemo
{
    public class SingletonDemo
    {
        private SingletonDemo() { }

        private static readonly SingletonDemo _instance = new SingletonDemo();
        public static SingletonDemo Instance
        {
            get { return _instance; }
        }

        private int count = 0;
        public int Count => count;
        public void Increase() => count++;
    }
}
