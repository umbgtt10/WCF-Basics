using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MultiplicationServiceLibrary
{
    public class SimpleMultiplicationService : MultiplicationService
    {
        public int MultiplyInt(int a, int b)
        {
            return a * b;
        }

        public int DivideInt(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception e)
            {
                var fault = new DivisionFault()
                {
                    Message = "The second operand cannot be zero!",
                    OperationMessage = e.Message
                };
                throw new FaultException<DivisionFault>(fault, new FaultReason("This is not  your business!"));
            }
        }

        public double MultiplyDouble(double a, double b)
        {
            return a * b;
        }

        public void Save(Student s)
        {
        }
    }
}
