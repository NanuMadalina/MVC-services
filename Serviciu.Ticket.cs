using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
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

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPrice(float Price)
        {
            this.price = Price;
        }


    }
}
