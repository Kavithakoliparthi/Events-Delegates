using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// Delegates and Events
    /// </summary>
    public class Sample
    {
        /// <summary>
        /// Creating a delegate
        /// </summary>
        /// <param name="message"></param>
        public delegate void MyDelegate(string message);
        /// <summary>
        /// Creating an Event
        /// </summary>
        public event MyDelegate MyEvent;
        /// <summary>
        /// RaiseEvent method
        /// </summary>
        /// <param name="message"></param>
        public void RaiseEvent(string message)
        {
            if (MyEvent != null)
             MyEvent(message);
       }
    }
    /// <summary>
    /// creating another class
    /// </summary>
     class Eventdemo
     {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.MyEvent += new Sample.MyDelegate(MyEvent);
            log.Info("Please enter a message\n");
            string msg = Console.ReadLine();
            obj.RaiseEvent(msg);
            Console.Read();
        }
        /// <summary>
        /// Creating MyEvent method
        /// </summary>
        /// <param name="str"></param>
        static void MyEvent(string str)
        {
            log.Info("Your Message is:" + str);
        }
    }
}
