using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransactionServiceClient.TransactionServiceReference;
using System.Transactions;
namespace TransactionServiceClient
{
    public partial class EmployeeMgmt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var TS = new EmployeeSalaryClient();
                using (TransactionScope Trs = new TransactionScope())
                {
                    int id=TS.CreateEmployee(new Employee() { EName = txtEmployeeName.Text, ESalary = double.Parse(txtEmployeeSalary.Text) });
                    if (id != 0)
                    {
                        TS.CreateSalaryHistory(new SalaryHistory() { Eid = id, ESalary = double.Parse(txtEmployeeSalary.Text), StDate = DateTime.Now, EdDate = null });
                    }
                        Trs.Complete();
                }
            }
            catch (Exception)
            {


            }

        }
    }
}