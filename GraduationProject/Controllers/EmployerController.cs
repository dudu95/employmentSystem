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
    public class EmployerController : ApiController
    {
        [Route("Employer/GetEmployer")]
        public IHttpActionResult GetEmployer()
        {
            try
            {
                List<T_Employer> EmployerList = new T_EmployerManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployerList, EmployerList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("Employer/GetEmployerPaging")]
        public IHttpActionResult GetEmployerPaging(int PageSize, int PageIndex)
        {
            List<T_Employer> allList = new T_EmployerManager().SelectALL();
            List<T_Employer> EmployerList = new T_EmployerManager().SelectALLPaginByRowNumber(PageSize, PageIndex);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_allCount_HttpCode("the account list paging", EmployerList, EmployerList.Count,allList.Count));
        }

        [Route("Employer/GetEmployerById")]
        public IHttpActionResult GetEmployerById(int id)
        {
            T_EmployerManager manager = new T_EmployerManager();
            T_Employer Employer = manager.SelectSingleLine_RTModel(new T_Employer() { employerId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployerById", Employer, 1));
        }

        [Route("Employer/GetEmployerByUsernameAndPassword")]
        public IHttpActionResult GetEmployerByUsernameAndPassword(string username, string password)
        {
            T_EmployerManager manager = new T_EmployerManager();
            T_Employer Employer = manager.SelectByUserNameAndPassword(username, password);
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployerByUsernameAndPassword", Employer, 1));
        }

        [Route("Employer/GetEmployerByCompanyCateId")]
        public IHttpActionResult GetEmployerByCompanyCateId(int companyCateId)
        {
            T_EmployerManager manager = new T_EmployerManager();
            List<T_Employer> EmployerList = manager.SelectByCompanyCateId(new T_Employer() { companyCateId = companyCateId });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetEmployerByEmployeeId", EmployerList, EmployerList.Count));
        }

        [Route("Employer/AddEmployer")]
        public IHttpActionResult AddEmployer(dynamic query)
        {
            try
            {
                T_Employer employer = new T_Employer();
                employer.name = query.name;
                employer.logo = query.logo;
                employer.site = query.site;
                employer.companyCateId = query.companyCateId;
                employer.investmentStateId = query.investmentStateId;
                employer.city = query.city;
                employer.address = query.address;
                employer.scale = query.scale;
                employer.intro = query.intro;
                employer.note = query.note;
                employer.username = query.username;
                employer.password = query.password;
                bool isAdd = new T_EmployerManager().IsInsert(employer);
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

        [Route("Employer/UpdateEmployer")]
        public IHttpActionResult UpdateEmployer(dynamic query)
        {
            try
            {
                T_Employer employer = new T_Employer();
                employer.employerId = query.employerId;
                employer.name = query.name;
                employer.logo = query.logo;
                employer.site = query.site;
                employer.companyCateId = query.companyCateId;
                employer.investmentStateId = query.investmentStateId;
                employer.city = query.city;
                employer.address = query.address;
                employer.scale = query.scale;
                employer.intro = query.intro;
                employer.note = query.note;
                employer.username = query.username;
                employer.password = query.password;
                bool isUpdate = new T_EmployerManager().IsUpdate(employer);
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
    }
}
