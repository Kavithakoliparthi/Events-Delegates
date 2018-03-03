using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// creating Generic Delegate
    /// </summary>
    class ClsDelegateDemo4
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Func Delegate
        /// Add Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public double Add(int a,double b,float c)
        {
            double d = a + b + c;
            log.Info("The addition of a,b and c is:"+d);
            return d;
        }
        /// <summary>
        /// Action Delegate
        /// Addition Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Addition(double a,float b)
        {
            double c = a + b;
            log.Info("The addition of a and b is:" + c);
        }
        /// <summary>
        /// Predicate Delegate
        /// Test Method
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool Test(string str)
        {
            if(str.Length>7)
            return true;
            else
            return false;
        }
    }
    /// <summary>
    /// Generic delegate class
    /// </summary>
    class GenericDelegateEx
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClsDelegateDemo4 obj = new ClsDelegateDemo4();
            Func<int, double, float, double> obj1 = new Func<int, double, float, double>(obj.Add);
            obj1.Invoke(34, 29.4,9.5f);

            Action<double, float> obj2 = new Action<double, float>(obj.Addition);
            obj2(8.5, 3.2f);

            Predicate<string> obj3 = new Predicate<string>(obj.Test);
            // (or) //Func<string, bool> obj3 = new Func<string, bool>(obj.Test);
            bool status = obj3.Invoke("dotnet language");
            log.Info(status);
            Console.ReadLine();
        }
    }
}
