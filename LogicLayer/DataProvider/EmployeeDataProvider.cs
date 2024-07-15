
using LogicLayers.BusinessController;
using LogicLayers.SQLHelper;
using Models.EmployeeInfo;

namespace LogicLayers.DataProvider
{
    public class EmployeeDataProvider
    {
        public EmployeeInfo InsertEmployeeData(EmployeeInfo objEmployeeInfo)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("@EmpName", objEmployeeInfo.Emp_Name),
                new KeyValuePair<string, object>("@Age", objEmployeeInfo.Age),
                new KeyValuePair<string, object>("@Gender", objEmployeeInfo.Gender),
                new KeyValuePair<string, object>("@Degination", objEmployeeInfo.Degination),
                new KeyValuePair<string, object>("@Salary", objEmployeeInfo.Salary)
            };
            SQLHandler SQLH = new SQLHandler();
            EmployeeInfo objEmployeeResponse = SQLH.ExecuteAsObject<EmployeeInfo>("[dbo].[usp_Employees_Insert]", ParaMeterCollection);
            return objEmployeeResponse;
        }
        public EmployeeInfo UpdateEmployeeData(EmployeeInfo objEmployeeInfo)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("@EmpId", objEmployeeInfo.Emp_Id),
                new KeyValuePair<string, object>("@EmpName", objEmployeeInfo.Emp_Name),
                new KeyValuePair<string, object>("@Age", objEmployeeInfo.Age),
                new KeyValuePair<string, object>("@Gender", objEmployeeInfo.Gender),
                new KeyValuePair<string, object>("@Degination", objEmployeeInfo.Degination),
                new KeyValuePair<string, object>("@Salary", objEmployeeInfo.Salary)
            };
            SQLHandler SQLH = new SQLHandler();
            EmployeeInfo objEmployeeResponse = SQLH.ExecuteAsObject<EmployeeInfo>("[dbo].[usp_Employees_Update]", ParaMeterCollection);
            return objEmployeeResponse;
        }
        public EmployeeInfo GetEmployeeData(int empid)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("@empId", empid)


            };
            SQLHandler SQLH = new SQLHandler();
            EmployeeInfo objEmployeeResponse = SQLH.ExecuteAsObject<EmployeeInfo>("[dbo].[usp_Employees_Select]", ParaMeterCollection);
            return objEmployeeResponse;
        }

        /// <summary>
        /// Getting List Of employee 
        /// </summary>
        /// <returns></returns>
        public List<EmployeeInfo> GetListEmployeeData()
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>();
            SQLHandler SQLH = new SQLHandler();
            List<EmployeeInfo> lstEmployee = SQLH.ExecuteAsList<EmployeeInfo>("[dbo].[usp_Employee_List]", ParaMeterCollection);
            return lstEmployee;
        }


    }
}