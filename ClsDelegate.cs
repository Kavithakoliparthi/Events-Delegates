using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// SingleCast Delegate with in the class
    /// </summary>
    class ClsDelegate
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Display Method
        /// </summary>
        /// <param name="s"></param>
        static void Display(string s)
        {
            log.Info("The value of S is:" + s);
        }
        /// <summary>
        /// Creating Delegate inside the class
        /// </summary>
        /// <param name="s1"></param>
        public delegate void mydelegate(string s1);
        /// <summary>
        /// In the main method instantiating a delegate and invoking delegate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            mydelegate obj = new mydelegate(Display);
            obj("Hi");
            Console.ReadLine();
        }
    }
}
