using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyasMinuteManagerApp.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }
        public int MeetingTypeID { get; set; }
        public DateTime MeetingDateTime { get; set; }
    }
}
