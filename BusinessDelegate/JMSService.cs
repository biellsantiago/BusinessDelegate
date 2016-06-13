using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegate
{
    class JMSService : IBusinessService
    {
        public void doProcessing()
        {
            Console.WriteLine("Processamento invocado pela JMS Service");
        }
    }
}
