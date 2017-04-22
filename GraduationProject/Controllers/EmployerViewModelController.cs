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
    public class EmployerViewModelController : ApiController
    {
        //当搜索框为空时，默认返回全部数据
        [Route("EmployerViewModel/GetEmployerViewModelBySearch")]
        public IHttpActionResult GetEmployerViewModelListBySearch()
        {
            try
            {
                List<EmployerViewModel> EmployerViewModelList = new EmployerViewModelManager().GetEmployerViewModelList();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployerViewModelList, EmployerViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("EmployerViewModel/GetEmployerViewModelBySearch")]
        public IHttpActionResult GetEmployerViewModelListBySearch(string name)
        {
            try
            {
                List<EmployerViewModel> EmployerViewModelList = new EmployerViewModelManager().GetEmployerViewModelListBySearch(name);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployerViewModelList, EmployerViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("EmployerViewModel/GetEmployerViewModelListByEmployerId")]
        public IHttpActionResult GetEmployerViewModelListByEmployerId(int employerId)
        {
            try
            {
                List<EmployerViewModel> EmployerViewModelList = new EmployerViewModelManager().GetEmployerViewModelListByEmployerId(employerId);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", EmployerViewModelList, EmployerViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }
    }
}
