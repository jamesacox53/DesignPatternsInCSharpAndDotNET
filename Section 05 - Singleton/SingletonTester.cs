using System;

namespace Section05Singleton
{
    public class SingletonTester
    {
        public static bool IsSingleton(Func<object> func)
        {
            object obj1 = func.Invoke();

            object obj2 = func.Invoke();

            return obj1 == obj2;
        }
    }
}
