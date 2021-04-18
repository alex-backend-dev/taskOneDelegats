using System;

namespace taskOneDelegats
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<Action<float>, int, float, bool> lambda = Function; 
            Action<float> action = Method; 

            Console.WriteLine(lambda(action, 2, 3.5f));
            Console.ReadLine();
        }
        static void Method(float s)
        {
            Console.WriteLine(s);
        }

        static bool Function(Action<float> action, int integer, float numeric)
        {
            float res = numeric % integer;
            action(res);
            return res >= 0;
        }
    }
}

