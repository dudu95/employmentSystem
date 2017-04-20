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
    public class EmployeeViewModelController : ApiController
    {
        //当搜索框为空时，默认返回全部数据
        [Route("EmployeeViewModel/GetEmployeeViewModelBySearch")]
        public IHttpActionResult GetEmployeeViewModelListBySearch()
        {
            try
            {
                List<EmployeeViewModel> EmployeeViewModelList = new EmployeeViewModelManager().GetEmployeeViewModelList();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployeeViewModelList, EmployeeViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("EmployeeViewModel/GetEmployeeViewModelBySearch")]
        public IHttpActionResult GetEmployeeViewModelListBySearch(string name)
        {
            try
            {
                List<EmployeeViewModel> EmployeeViewModelList = new EmployeeViewModelManager().GetEmployeeViewModelListBySearch(name);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployeeViewModelList, EmployeeViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("EmployeeViewModel/GetEmployeeViewModelByPaging")]
        public IHttpActionResult GetEmployeeViewModelByPaging(int PageIndex, int pageSize)
        {
            try
            {
                List<EmployeeViewModel> allList = new EmployeeViewModelManager().GetEmployeeViewModelList();
                List<EmployeeViewModel> EmployeeViewModelList = Helper.Paging.ListPaging<EmployeeViewModel>(allList, PageIndex, pageSize);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployeeViewModelList, EmployeeViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }
    }
}
