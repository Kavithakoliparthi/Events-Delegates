using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegatesandEvents
{
    /// <summary>
    /// this class is an example for the behavior of 
    /// async and await combination with lambda expression.
    /// </summary>

    class Class3
    {
            private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            /// <summary>
            /// Asyncmethod
            /// </summary>
            static void AsyncMethod()
            {
                log.Info("starting");
                var worker = new Worker();
                worker.DoWork();
                while (!worker.IsComplete)
                {
                    Thread.Sleep(1000);
                }
            }
            static void Main(string[] args)
            {
                AsyncMethod();
                Console.Read();
            }
        }
        /// <summary>
         /// 
         /// </summary>
        class Worker
        {
            private static  log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            public bool IsComplete
            {
                get;
                private set;
            }
            /// <summary>
            /// async and await combination which calls another method internally.
            /// </summary>
            public async void DoWork()
            {
                this.IsComplete = false;
                log.Info("Doing Work....");
                await LongOperation();
                log.Info("work completed");
                IsComplete = true;
            }
            /// <summary>
            /// working status of the worker
            /// </summary>
            /// <returns></returns>
            private Task LongOperation()
            {
                return Task.Factory.StartNew(() =>
                {
                    log.Info("Working");
                    Thread.Sleep(2000);
                });
            }
        }
    }
}
