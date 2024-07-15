using LogicLayers.DataProvider;
using Models.EmployeeInfo;

namespace LogicLayers.BusinessController
{
    public class BusinessEmployees
    {
        public int EmployeeInsert(EmployeeInfo objEmployeeInfo)
        {
            EmployeeDataProvider objEmployeeDataProvider = new EmployeeDataProvider();
            objEmployeeInfo = objEmployeeDataProvider.InsertEmployeeData(objEmployeeInfo);
            int empId = 0;
            if (objEmployeeInfo != null)
            {
                empId = objEmployeeInfo.Emp_Id;
            }
            return empId;
        } 
        public EmployeeInfo StudentGetByRollNo(int empid)
        {
            EmployeeDataProvider objEmployeeDataProvider = new EmployeeDataProvider();
            EmployeeInfo objEmployeeInfo = objEmployeeDataProvider.GetEmployeeData(empid);
            
            return objEmployeeInfo;
        }
        public List<EmployeeInfo> EmployeeGetList()
        {
            EmployeeDataProvider objEmployeeDataProvider = new EmployeeDataProvider();
            List<EmployeeInfo> lstEmployeeInfo = objEmployeeDataProvider.GetListEmployeeData();
            return lstEmployeeInfo;
        }
   
    }
}