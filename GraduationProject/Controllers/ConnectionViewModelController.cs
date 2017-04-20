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
    public class ConnectionViewModelController : ApiController
    {
        [Route("ConnectionViewModel/GetConnectionViewModel")]
        public IHttpActionResult GetConnectionViewModel()
        {
            try
            {
                List<ConnectionViewModel> ConnectionViewModelList = new ConnectionViewModelManager().GetConnectionViewModelList();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", ConnectionViewModelList, ConnectionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("ConnectionViewModel/GetConnectionViewModelListByEmployeeId")]
        public IHttpActionResult GetConnectionViewModelListByEmployeeId(int employeeId)
        {
            try
            {
                List<ConnectionViewModel> ConnectionViewModelList = new ConnectionViewModelManager().GetConnectionViewModelListByEmployeeId(employeeId);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", ConnectionViewModelList, ConnectionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("ConnectionViewModel/GetConnectionViewModelListByEmployerId")]
        public IHttpActionResult GetConnectionViewModelListByEmployerId(int employerId)
        {
            try
            {
                List<ConnectionViewModel> ConnectionViewModelList = new ConnectionViewModelManager().GetConnectionViewModelListByEmployerId(employerId);
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", ConnectionViewModelList, ConnectionViewModelList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }
    }
}
