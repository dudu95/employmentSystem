using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GraduationProject.Controllers
{
    public class EmployeeController : ApiController
    {
        [Route("Employee/GetEmployee")]
        public IHttpActionResult GetEmployee()
        {
            try
            {
                List<T_Employee> EmployeeList = new T_EmployeeManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployeeList, EmployeeList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("Employee/GetEmployeePaging")]
        public IHttpActionResult GetEmployeePaging(int PageSize, int PageNumber, string DataOrderBy)
        {
            List<T_Employee> EmployeeList = new T_EmployeeManager().SelectALLPaginByRowNumber(PageSize, PageNumber, DataOrderBy);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account list paging",EmployeeList, EmployeeList.Count));
        }

        [Route("Employee/GetEmployeeById")]
        public IHttpActionResult GetEmployeeById(int id)
        {
            T_EmployeeManager manager = new T_EmployeeManager();
            T_Employee Employee = manager.SelectSingleLine_RTModel(new T_Employee() { employeeId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployeeById", Employee, 1));
        }

        [Route("Employee/GetEmployeeByUsernameAndPassword")]
        public IHttpActionResult GetEmployeeByUsernameAndPassword(string username, string password)
        {
            T_EmployeeManager manager = new T_EmployeeManager();
            T_Employee Employee = manager.SelectByUserNameAndPassword(username,password);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployeeByUsernameAndPassword", Employee, 1));
        }

        [Route("Employee/GetEmployeeByName")]
        public IHttpActionResult GetEmployeeByName(string name)
        {
            T_EmployeeManager manager = new T_EmployeeManager();
            T_Employee Employee = manager.SelectSingleLine_RTModel(new T_Employee() { name = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployeeByName", Employee, 1));
        }

        [Route("Employee/GetEmployeeByUserName")]
        public IHttpActionResult GetEmployeeByUserName(string username)
        {
            T_EmployeeManager manager = new T_EmployeeManager();
            T_Employee Employee = manager.SelectSingleLine_RTModel(new T_Employee() { username = username });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployeeByName", Employee, 1));
        }

        [Route("Employee/UpdateEmployee")]
        public IHttpActionResult UpdateEmployee(dynamic query)
        {
            try
            {
                T_Employee employee = new T_EmployeeManager().SelectSingleLine_RTModel(new T_Employee{employeeId=query.employeeId});
                employee.employeeId = query.employeeId;
                employee.name = query.name;
                employee.telphone = query.telphone;
                employee.email = query.email;
                employee.educationId = query.educationId;
                employee.graduatedSchool = query.graduatedSchool;
                employee.major = query.major;
                employee.workingLifeId = query.workingLifeId;
                employee.targetPosition = query.targetPosition;
                employee.note = query.note;
                employee.username = query.username;
                employee.password = query.password;
                bool isUpdate = new T_EmployeeManager().IsUpdate(employee);
                if (isUpdate)
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("update success", true));
                }
                else
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("update faild", false));
                }
            }
            catch (Exception ex)
            {
                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 1));
            }

        }

        [Route("Employee/AddEmployee")]
        public IHttpActionResult AddEmployee(dynamic query)
        {
            try
            {
                T_Employee employee = new T_Employee();
                employee.name = query.name;
                employee.telphone = query.telphone;
                employee.email = query.email;
                employee.educationId = query.educationId;
                employee.graduatedSchool = query.graduatedSchool;
                employee.major = query.major;
                employee.workingLifeId = query.workingLifeId;
                employee.targetPosition = query.targetPosition;
                employee.note = query.note;
                employee.username = query.username;
                employee.password = query.password;
                bool isAdd = new T_EmployeeManager().IsInsert(employee);
                if (isAdd)
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("add success", true));
                }
                else
                {
                    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("add faild", false));
                }
            }
            catch (Exception ex)
            {
                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 1));
            }

        }


        //[Route("Account/DeleteAccountById")]
        //[HttpPost,HttpDelete]//这里方法名称带Delete如果不配置这里允许post请求，那么必须使用delete请求方式
        //public IHttpActionResult DeleteAccountById(int id)
        //{
        //    tb_AccountManager manager = new tb_AccountManager();
        //    bool isDelete = manager.IsDelete(new tb_Account() { ID = id });
        //    if (isDelete)
        //    {
        //    return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete success", true));
        //    }
        //    else
        //    {
        //        return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("delete faild", false));
        //    }
        // }

    }
}
