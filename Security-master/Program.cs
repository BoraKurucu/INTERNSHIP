using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*      4624: An account was successfully logged on.
                    4625: An account failed to log on.
                    4648: A logon was attempted using explicit credentials.
                    4675: SIDs were filtered.
            */
            string eventLogName = "Security";

            EventLog eventLog = new EventLog();
            eventLog.Log = eventLogName;
            List<EventObject> list = new List<EventObject>();
            List<string> names = new List<string>();

            foreach (EventLogEntry log in eventLog.Entries)
            {
                if (log.EventID == 4648 || log.EventID == 4625)
                {
                    if (!(names.Contains(log.ReplacementStrings[12])))
                    {
                        EventObject oe = new EventObject();
                        names.Add(log.ReplacementStrings[12]);
                        oe.userName = log.ReplacementStrings[5];
                        oe.ip = log.ReplacementStrings[12];
                        oe.attempt = 1;
                        list.Add(oe);
                    }
                    else
                    {
                        string ip2 = "null";
                        string userName2 = "null";
                        int attempt2 = 0;

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].ip.Equals(log.ReplacementStrings[12]))
                            {
                                ip2 = list[i].ip;
                                userName2 = list[i].userName;
                                attempt2 = list[i].attempt + 1;
                                list.RemoveAt(i);
                                break;
                            }
                        }
                            EventObject oe = new EventObject();
                            oe.userName = userName2;
                            oe.ip = ip2;
                            oe.attempt = attempt2;
                            list.Add(oe);


                     
                    }


                    //Console.WriteLine("{0}\n", log.Index);
                    //string result = log.
                }

            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("{0}\n", "username is " + list[i].userName + " ip is " + list[i].ip + " failed attempt number is " + list[i].attempt);

            }
            Console.WriteLine("{0}\n", "bye");


        }
    }
    public class EventObject
    {
        public string userName;
        public string ip;
        public int attempt;
    }
}
