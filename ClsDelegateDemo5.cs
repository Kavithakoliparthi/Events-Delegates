using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// Generic Delegate
    /// </summary>
    class ClsDelegateDemo5
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// I the Main method creating generic delegate with Lambda expression
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClsDelegateDemo4 obj = new ClsDelegateDemo4();
            Func<int, double, float, double> obj1 = (a,b,c) =>
            {
                double d = a + b + c;
                return d;
            };
            double result=obj1.Invoke(34, 29.4, 9.5f);
            log.Info("The addition of a,b and c is:" + result);

            Action<double, float> obj2 = (a,b) =>
            {
                double c = a + b;
                log.Info("The addition of a and b is:" + c);
            };
            obj2(8.5, 3.2f);

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 7)
                    return true;
                else
                    return false;
            };
            bool status = obj3.Invoke("dotnet language");
            log.Info(status);
            Console.ReadLine();
        }
    }
}
