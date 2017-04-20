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
    public class ConnectedStateController : ApiController
    {
        [Route("ConnectedState/GetConnectedState")]
        public IHttpActionResult GetConnectedState()
        {
            try
            {
                List<T_ConnectedState> ConnectedState = new T_ConnectedStateManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", ConnectedState,ConnectedState.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("ConnectedState/GetConnectedStateById")]
        public IHttpActionResult GetConnectedStateById(int id)
        {
            T_ConnectedStateManager manager = new T_ConnectedStateManager();
            T_ConnectedState ConnectedState = manager.SelectSingleLine_RTModel(new T_ConnectedState() { connectedStateId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetConnectedStateById", ConnectedState, 1));
        }

        [Route("ConnectedState/GetConnectedStateByName")]
        public IHttpActionResult GetConnectedStateByName(string name)
        {
            T_ConnectedStateManager manager = new T_ConnectedStateManager();
            T_ConnectedState ConnectedState = manager.SelectByName_RTModel(new T_ConnectedState() { connectedName = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetConnectedStateByName", ConnectedState, 1));
        }
    }
}
