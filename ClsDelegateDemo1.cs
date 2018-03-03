using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// SingleCast Delegate outside of the class
    /// </summary>
    class ClsDelegateDemo1
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Display Method
        /// </summary>
        /// <param name="s"></param>
        public void Display(String s)
        {
            log.Info("The value of S is:" + s);
        }
    }
    /// <summary>
    /// Creating Delegate Outside the class
    /// </summary>
    /// <param name="a"></param>
    public delegate void sampledelegate(string a);
    /// <summary>
    /// Creating another class
    /// </summary>
    class SingleCastDelegate
    {
        /// <summary>
        /// In the main method instantiating a delegate and invoking delegate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ClsDelegateDemo1 obj = new ClsDelegateDemo1();
            sampledelegate obj1 = new sampledelegate(obj.Display);
            obj1("Hello");
            Console.ReadLine();
        }
    }
}
