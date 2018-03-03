using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// Multicast Delegate with in the class
    /// </summary>
    public class MultiCastDelegateDemo
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Area of the Rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double GetArea(double width,double height)
        {
            double d = width * height;
            log.Info("The Rectangle area is:"+d);
            return d;
        }
        /// <summary>
        /// Perimeter of the Rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public double GetPerimeter(double width,double height)
        {
            double d = 2 * (width + height);
            log.Info("The Rectangle Perimeter is:" + d);
            return d;
        }
        /// <summary>
        /// Creating Delegate
        /// </summary>
        /// <param name="weight"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public delegate double RectangleDelegate(double weight,double height);
        /// <summary>
        /// In the Main method instantiating the delegate and invoking the delegate
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            MultiCastDelegateDemo obj = new MultiCastDelegateDemo();
            RectangleDelegate sd = new RectangleDelegate(obj.GetArea);
            sd += obj.GetPerimeter;
            sd(2.7, 3.9);
            sd(5.1, 8.3);
            Console.ReadLine();
        }
    }
}
