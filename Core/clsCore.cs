using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    static public class clsCore
    {
        public enum enBrowser { Chrome = 0, Edge = 1 }
        public static enBrowser browser = enBrowser.Chrome;

        public static void WriteExceptionInLogger(Exception e)
        {
            string sourceName = "Modify Your Browser";


            if (!EventLog.SourceExists(sourceName)) 
            {
                EventLog.CreateEventSource(sourceName, "Application"); 
            }

            // Log an inforamtion event
            EventLog.WriteEntry(sourceName, e.Message, EventLogEntryType.Error);
        }

         public class BlockedWebsite
        {
            public string ID { get; set; }
            public string Website { get; set; }

        }

    }
}
