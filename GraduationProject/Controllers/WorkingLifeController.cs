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
    public class WorkingLifeController : ApiController
    {
        [Route("WorkingLife/GetWorkingLife")]
        public IHttpActionResult GetWorkingLife()
        {
            try
            {
                List<T_WorkingLife> WorkingLifeList = new T_WorkingLifeManager().SelectALL();
                return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("the account info ccount", WorkingLifeList, WorkingLifeList.Count));
            }
            catch (Exception ex)
            {

                return Json(Return_Helper_DG.Error_EMsg_Ecode_Elevel_HttpCode(ex.ToString(), 0));
            }
        }

        [Route("WorkingLife/GetWorkingLifeById")]
        public IHttpActionResult GetWorkingLifeById(int id)
        {
            T_WorkingLifeManager manager = new T_WorkingLifeManager();
            T_WorkingLife WorkingLife = manager.SelectSingleLine_RTModel(new T_WorkingLife() { workingLifeId = id });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetWorkingLifeById", WorkingLife, 1));
        }

        [Route("WorkingLife/GetWorkingLifeByName")]
        public IHttpActionResult GetWorkingLifeByName(string name)
        {
            T_WorkingLifeManager manager = new T_WorkingLifeManager();
            T_WorkingLife WorkingLife = manager.SelectByName_RTModel(new T_WorkingLife() { workingLife = name });
            return Json(Return_Helper_DG.Success_Desc_Data_DCount_HttpCode("GetWorkingLifeByName", WorkingLife, 1));
        }
    }
}
