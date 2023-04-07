using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton instance = new Singleton();
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();
            if (instance1.Equals(instance2))
            {
                Console.WriteLine("Okay");
            }
        }
    }
}
