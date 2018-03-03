using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// 
    /// </summary>
    class Class2
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            callMethod();
            Console.ReadKey();
        }
        public static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }
        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 40; i++)
                {
                    log.Info(" Method 1");
                    count += 1;
                }
            });
            return count;
        }
        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                log.Info(" Method 2");
            }
        }
        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}
