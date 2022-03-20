using System;
using System.Collections;



namespace Rendimiento
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ArrayList objectos = new ArrayList();

            objectos.Add(50); //boxing

            int x = (int)objectos[0];//unboxing

            foreach(int i in objectos)
            {

                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
