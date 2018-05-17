using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Ticket
    {
        public int ticketID { get; set; }
        public float discount { get; set; }
        public float price { get; set; }
        public DateTime? date { get; set; }


        public string movieName { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }



        public int? movieScheduleID { get; set; }
        public int? hallID { get; set; }
        public virtual Hall Hall { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual MovieSchedule MovieSchedule { get; set; }

    }
}
