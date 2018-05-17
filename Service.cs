using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Ticket> applyDiscount(List<Ticket> list, float discount)
        {
            //List<Ticket> newList = new List<Ticket>();
            foreach (Ticket item in list)
            {
                
                float discountedPrice = item.GetPrice() - discount * item.GetPrice();
                item.SetPrice(discountedPrice);
                //list.Add(item);
            }
            return list;
        }
        public string getData(string text)
        {
            return text;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
