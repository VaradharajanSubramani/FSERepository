using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ass21Ser
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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

        public string SayHello(string name)
        {
            DateTime currentdate = System.DateTime.Now;
            string output;

            if (currentdate.Hour < 12)
            {
                output = "Good Morning";
            }else if(currentdate.Hour < 16 && currentdate.Hour > 12)
            {
                output = "Good AfterNoon";
            }
            else
            {
                output = "Good Evening";
            }
            return string.Format("{0}{1}{2}", output, " ", name);
        }

        public string TodayProgram(string name)
        {
            string output;
            DayOfWeek today = DateTime.Today.DayOfWeek;

            if (today == DayOfWeek.Saturday || today == DayOfWeek.Sunday)
            {
                output = "Happy weekend";
            } else
            {
                output = "Enjoy Working day";
            }

            return string.Format("{0}{1}{2}", output, " ", name); ;

        }
    }
}
