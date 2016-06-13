using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegate
{
    public class BusinessLookUp
    {
        public IBusinessService getBusinessService(String serviceType)
        {

            if (serviceType.Equals("EJB"))
            {
                return new EJBService();
            }
            else
            {
                return new JMSService();
            }
        }
    }
}
