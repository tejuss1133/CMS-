
using LogicLayers.BusinessController;
using LogicLayers.SQLHelper;
using Models.EmployeeInfo;
using Models.StudentInfo;

namespace LogicLayers.DataProvider
{
    public class StudentDataProvider
    {
        public StudentInfo InsertStudentData(StudentInfo objStudentInfo)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("@Name", objStudentInfo.Name),
                new KeyValuePair<string, object>("@LastName", objStudentInfo.LastName),
                new KeyValuePair<string, object>("@Section", objStudentInfo.Section),
                new KeyValuePair<string, object>("@PhoneNo",objStudentInfo.PhoneNo)
            };


            SQLHandler SQLH = new SQLHandler();
            StudentInfo objStudentResponse = SQLH.ExecuteAsObject<StudentInfo>("[dbo].[usp_Student_Insert]", ParaMeterCollection);
            return objStudentResponse;
        }
        public EmployeeInfo UpdateStdentData(StudentInfo objStudentInfo)
        {
            List<KeyValuePair<string, object>> ParaMeterCollection = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("@Name", objStudentInfo.Name),
                new KeyValuePair<string, object>("@LastName", objStudentInfo.LastName),
                new KeyValuePair<string, object>("@Section", objStudentInfo.Section),
                new KeyValuePair<string, object>("@PhoneNo",objStudentInfo.PhoneNo),
               
            };
            SQLHandler SQLH = new SQLHandler();
            StudentInfo objStudentResponse = SQLH.ExecuteAsObject<StudentInfo>("[dbo].[usp_Student_Insert]", ParaMeterCollection);
            return objStudentResponse;
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