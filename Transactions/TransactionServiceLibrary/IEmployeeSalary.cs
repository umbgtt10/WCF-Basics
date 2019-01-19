using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Transactions;
namespace TransactionServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface IEmployeeSalary
    {
        [OperationContract] 
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void CreateEmployee(Employee E);


        [OperationContract] 
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void CreateSalaryHistory(SalaryHistory SH);
    }
}
    	
    
