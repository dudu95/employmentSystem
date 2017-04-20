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
    public class InvestmentStateController : ApiController
    {
        [Route("InvestmentState/GetInvestmentState")]
        public IHttpActionResult GetInvestmentState()
        {
            try
            {
                List<T_InvestmentState> InvestmentState = new T_InvestmentStateManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", InvestmentState, InvestmentState.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("InvestmentState/GetInvestmentStateById")]
        public IHttpActionResult GetInvestmentStateById(int id)
        {
            T_InvestmentStateManager manager = new T_InvestmentStateManager();
            T_InvestmentState InvestmentState = manager.SelectSingleLine_RTModel(new T_InvestmentState() { investmentStateId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetInvestmentStateById", InvestmentState, 1));
        }

        [Route("InvestmentState/GetInvestmentStateByName")]
        public IHttpActionResult GetInvestmentStateByName(string name)
        {
            T_InvestmentStateManager manager = new T_InvestmentStateManager();
            T_InvestmentState InvestmentState = manager.SelectByName_RTModel(new T_InvestmentState() { stateName = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetInvestmentStateByName", InvestmentState, 1));
        }
    }
}
