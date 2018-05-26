using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using cmkb_sync.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace cmkb_sync
{
    class Program
    {
        private static readonly object _log_locker = new object();
        private static bool isServiceRunning = false;
        public static ConcurrentQueue<KMQueue> KmQueue=new ConcurrentQueue<KMQueue>();
        public static IConfiguration Configuration { get; set; }

        private static System.Threading.ManualResetEvent _event1 = new ManualResetEvent(true);
        private static System.Threading.ManualResetEvent _event2 = new ManualResetEvent(true);
        private static System.Threading.ManualResetEvent _event3 = new ManualResetEvent(true);
        private static WaitHandle[] events = { _event1, _event2, _event3 };
        public static void Log(string log)
        {
            lock (_log_locker)
            {

                if (Environment.UserInteractive)
                {
                    Console.WriteLine(DateTime.Now + " : " + log);
                }

            }


        }
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();

            Helpers.connectionstring_kb_cn = Configuration["cnkbdb"];
            Helpers.connectionstring_kb_tq = Configuration["tqkbdb"];


            bool stoped = false;
            isServiceRunning = true;
            var cts = new CancellationTokenSource();
            new Thread(async () =>
            {
                while (isServiceRunning)
                {
                    _event1.Reset();
                    try
                    {
                        using (var db = new Db(Helpers.GetKBConnString(true)))
                        {

                            db.Database.ExecuteSqlCommand(new RawSqlString(@"DELETE from
                                killboard_waiting_api
                            using killboard_kill  b
                            WHERE
                            killboard_waiting_api.""killID""=b.""killID"" and
                            (b.""APIverified"" = TRUE or b.""CRESTverified""=TRUE )"));

                            var query = db.killboard_waiting_api.Where(p => p.Error == false || p.Error == null);
                            foreach (var killboardWaitingApi in query)
                            {
                                KmQueue.Enqueue(new KMQueue() { istq = true, waiting = killboardWaitingApi });
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        Log(e.ToString());
                    }

                    _event1.Set();
                    await Task.Delay(5000, cts.Token);
                }
            }).Start();

            Console.CancelKeyPress += delegate
            {
                Log("Shutting Down");
                isServiceRunning = false;
               
                cts.Cancel();
                WaitHandle.WaitAll(events);
                Log("Exited!");
                stoped = true;
            };
            while (!stoped)
            {
                Thread.Sleep(1000);
            }
        }
    }
}
