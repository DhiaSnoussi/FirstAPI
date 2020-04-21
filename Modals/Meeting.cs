using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Modals
{
    public class Meeting
    {
        public int ID { get; set; }

        public string MeetingName { get; set; }

        public int Duration { get; set; } // Hours

        public DateTime Date { get; set; }
    }
}
