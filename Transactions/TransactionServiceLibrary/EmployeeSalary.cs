using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace TransactionServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
        
    [ServiceBehavior(TransactionIsolationLevel=IsolationLevel.Serializable,TransactionTimeout="00:00:30",
                     InstanceContextMode = InstanceContextMode.PerSession, TransactionAutoCompleteOnSessionClose = true)]
    public class EmployeeSalary : IEmployeeSalary
    {
        private int _eid = 0;

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void CreateEmployee(Employee E)
        {
            var con = new SqlConnection("Data Source=DESKTOP-3ABOOA3\\sqlexpress01;Initial Catalog=TransactionDb;Integrated Security=True");
            var cmd = new SqlCommand("insert into Employee (EName,ESalary) values (@EName,@ESalary); select SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@EName", E.EName);
            cmd.Parameters.AddWithValue("@ESalary", E.ESalary);
            con.Open();
            SqlDataReader EmployeeReader = cmd.ExecuteReader();
            if (EmployeeReader.Read())
            {
                _eid = int.Parse(EmployeeReader[0].ToString());
            }
            EmployeeReader.Close();
            con.Close();
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void CreateSalaryHistory(SalaryHistory SH)
        {
            var con = new SqlConnection("Data Source=DESKTOP-3ABOOA3\\sqlexpress01;Initial Catalog=TransactionDb;Integrated Security=True");
            var cmd = new SqlCommand("insert into SalaryHistory (Eid,ESalary,StDate,EdDate) values (@Eid,@ESalary,@StDate,NULL)", con);
            cmd.Parameters.AddWithValue("@Eid", _eid);
            cmd.Parameters.AddWithValue("@ESalary", SH.ESalary);
            cmd.Parameters.AddWithValue("@StDate", SH.StDate);
            con.Open();
            cmd.ExecuteNonQuery();            
            con.Close();
        }
    }
}
