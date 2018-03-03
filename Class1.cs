using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    class Class1
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Main method call two methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }
        /// <summary>
        /// method1
        /// </summary>
        /// <returns></returns>
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 40; i++)
                {
                        log.Info(" Method 1");
                }
            });
        }

        /// <summary>
        /// method2
        /// </summary>
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }
    }
}
