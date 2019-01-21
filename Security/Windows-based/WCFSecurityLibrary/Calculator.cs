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
        [PrincipalPermission(SecurityAction.Demand, Role = "Lead")]
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

        public int Subtract(int a, int b)
        {
            try
            {
                var user = new WindowsPrincipal((WindowsIdentity)Thread.CurrentPrincipal.Identity);
                if (user.IsInRole("Lead"))
                {
                    Console.WriteLine($"Logged in as user:{Thread.CurrentPrincipal.Identity.Name}");
                    return a + b;
                }
                else
                {
                    throw new FaultException($"Access denied for user: {user}");
                }
            }
            catch (Exception)
            {
                throw new FaultException("Access denied");
            }

        }

        [PrincipalPermission(SecurityAction.Demand, Role = "Users")]
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
