using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// Multicast Delegate outside of the class
    /// </summary>
    public class ClsDelegateDemo2
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Addition Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public int Add(int a, int b)
        {
            int c = a + b;
            log.Info("The Addition of two numbers:" + c);
            return c;
        }
        /// <summary>
        /// Subtraction Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public int Sub(int a, int b)
        {
            int c = a - b;
            log.Info("The Subtraction of two numbers:" + c);
            return c;
        }
        /// <summary>
        /// Multiplication Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public int Mul(int a, int b)
        {
            int c = a * b;
            log.Info("The Multiplication of two numbers:" + c);
            return c;
        }
        /// <summary>
        /// Division Method
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public int Div(int a,int b)
        {
            int c = a / b;
            log.Info("The Division of two number:"+c);
            return c;
        }
    }
    /// <summary>
    /// creating Delegate
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public delegate int mydelegate(int a, int b);
    /// <summary>
    /// Multicast Delegate
    /// </summary>
    public class MulticastDemo
    {
        /// <summary>
        /// Main method instantiating and invoking delegate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClsDelegateDemo2 obj = new ClsDelegateDemo2();
            mydelegate obj1 = new mydelegate(obj.Add);
            obj1 += obj.Sub;
            obj1 += obj.Mul;
            obj1 += obj.Div;
            obj1(20, 6);
            Console.ReadLine();
        }
    }
}
