using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading;

namespace WCFSecurityLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            try
            {
                Console.WriteLine($"Logged in as used:{Thread.CurrentPrincipal.Identity.Name}");
                return a + b;
            }
            catch (Exception)
            {
                throw new FaultException("Access denied");
            }

        }

        public int Multiply(int a, int b)
        {
            try
            {
                return a * b;
            }
            catch (Exception)
            {
                throw new FaultException("Access denied");
            }
        }
    }
}
