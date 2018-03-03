using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// creating Delegate
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public delegate double AddDelegate(double x, double y);
    public delegate void SubDelegate(int a, int b);
    public delegate bool checkLengthDelegate(string s);
    public delegate bool CalLengthDelegate(string str);
    /// <summary>
    /// Generic Delegate (Func,Action,Predicate)
    /// </summary>
   public class ClsDelegatedemo3
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Func Delegate
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double Add(double x,double y)
        {
            double d = x + y;
            log.Info("The Addition of two numbers x and y is:" + d);
            return d;
        }
        /// <summary>
        /// Action Delegate
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Sub(int a,int b)
        {
            int c = a + b;
            log.Info("The Addition of two number a and b is:"+c);
        }
        /// <summary>
        /// Predicate Delegate
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckLength(string s)
        {
            if(s.Length>5)
            return true;
            else 
            return false;
        }
        /// <summary>
        /// Predicate Delegate
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public bool CalLength(string str)
        {
            if(str.Length>=4)
            return true;
            else
            return false;
        }
    }
    public class GenericDelegate
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Instantiating and Invoking Delegate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClsDelegatedemo3 obj = new ClsDelegatedemo3();
            AddDelegate obj1 = new AddDelegate(obj.Add);
            obj1.Invoke(26.3, 48.9);

            SubDelegate obj2 = new SubDelegate(obj.Sub);
            obj2.Invoke(32,47);

            checkLengthDelegate obj3 = new checkLengthDelegate(obj.CheckLength);
            bool status=obj3.Invoke("false");
            log.Info(status);
            CalLengthDelegate obj4 = new CalLengthDelegate(obj.CalLength);
            bool status1=obj4.Invoke("true");
            log.Info(status1);
            Console.ReadLine();
        }
    }
}
